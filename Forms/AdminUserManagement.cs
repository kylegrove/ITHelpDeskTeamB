using Microsoft.Data.SqlClient;

namespace ITHelpDeskTeamB
{
    public partial class AdminUserManagement : Form
    {
        private StringConnection s = new StringConnection();
        private UserDatabaseManager dbManager;
        public AdminUserManagement()
        {
            InitializeComponent();
            dbManager = new UserDatabaseManager();
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dbManager.LoadUsers();
        }

        

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createNewUser = new CreateUserForm();
            createNewUser.FormClosed += (s, args) => dataGridView1.DataSource = dbManager.LoadUsers(); // Refresh after creating user
            createNewUser.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected user information
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
            string userName = selectedRow.Cells["UserName"].Value.ToString();

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete user '{userName}'?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = dbManager.deleteUser(userName, userId);

                    if (success)
                    {
                        MessageBox.Show("User deleted successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbManager.LoadUsers();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}