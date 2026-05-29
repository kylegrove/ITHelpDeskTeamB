namespace ITHelpDeskTeamB
{
    public partial class RaiseTicketForm : Form
    {
        private string username;
        public RaiseTicketForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string userDepartment = com_Department.Text;
            string ticketDescription = txt_Describe.Text;
            int userUrgency = (int)nud_Urgency.Value;
            //placeholder
            string ticketDate = dtp_DateTime.Value.ToString("yyyy-MM-dd");
            string currentStatus = "Unsolved";
            TicketDatabaseManager ticketdatabasemanager = new TicketDatabaseManager();
            UserDatabaseManager userdatabasemanager = new UserDatabaseManager();
            User user = userdatabasemanager.GetUser(username);
            try
            {
                ticketdatabasemanager.InsertTicket(ticketDescription, currentStatus, ticketDate, userUrgency, user.userID);
                MessageBox.Show("Ticket submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
