using ITHelpDeskTeamB.Forms;

namespace ITHelpDeskTeamB
{
    public partial class MemberForm : Form
    {
        private string username;
        public MemberForm(string username)
        {
            InitializeComponent();
            this.username = username;
            label1.Text = "Logged in as " + username;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OnlineHelpForm onlinehelpform = new OnlineHelpForm();
            onlinehelpform.Show();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            RaiseTicketForm raiseTicketForm = new RaiseTicketForm(username);
            raiseTicketForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            //view my tickets button
            MyTickets mytickets = new MyTickets(label1.Text.Substring(13));
            mytickets.Show();
        }

        private void btnExisting_Click(object sender, EventArgs e)
        {
            ExistingIssues existingIssues = new ExistingIssues();
            this.Hide(); 
        }
    }
}
