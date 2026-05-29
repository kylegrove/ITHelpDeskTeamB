using Microsoft.Data.SqlClient;

namespace ITHelpDeskTeamB
{
    public partial class CreateUserForm : Form
    {
        private UserDatabaseManager dbManager;

        public CreateUserForm()
        {
            InitializeComponent();
            dbManager = new UserDatabaseManager();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUserType.SelectedItem == null)
            {
                MessageBox.Show("Please select a user type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = dbManager.CreateNewUser(
                   txtUserName.Text.Trim(),
                   txtUserFirst.Text.Trim(),
                   txtUserLast.Text.Trim(),
                   txtPassword.Text.Trim(),
                   cmbUserType.SelectedItem.ToString(),
                   txtEmail.Text.Trim(),
                   txtPhone.Text.Trim()
               );

                if (success)
                {
                    // Create the user object
                    BuildUser userTypeObj = new BuildUser(
                        dbManager.getUserCount(), 
                        txtUserName.Text.Trim(),
                        txtUserFirst.Text.Trim(),
                        txtUserLast.Text.Trim(),
                        txtPassword.Text.Trim(),
                        cmbUserType.SelectedItem.ToString(),
                        txtEmail.Text.Trim(),
                        txtPhone.Text.Trim()
                    );

                    User currentUser = userTypeObj.CreateUserObject();
                    dbManager.setUserCount(dbManager.getUserCount() + 1); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create user.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}