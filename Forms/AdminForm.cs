namespace ITHelpDeskTeamB
{
    public partial class AdminForm : Form
    {
        public AdminForm(string username)
        {
            InitializeComponent();
            lblUsername.Text = "Logged in as " + username + " [ADMIN]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUserManagement adminUsers = new AdminUserManagement();
            adminUsers.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AdminViewTicketForm admTicket = new AdminViewTicketForm();
            admTicket.Show();
        }
    }
}
