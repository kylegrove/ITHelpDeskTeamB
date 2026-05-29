using Microsoft.Data.SqlClient;
using System.Data;

namespace ITHelpDeskTeamB
{
    public partial class MyTickets : Form
    {
        private string userName;
        public MyTickets(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            lblUser.Text = "Logged in as: " + userName;
            TicketDatabaseManager ticketdatabasemanager = new TicketDatabaseManager();
            UserDatabaseManager userdatabasemanager = new UserDatabaseManager();
            User user = userdatabasemanager.GetUser(userName);
            dataGridView1.DataSource = ticketdatabasemanager.LoadSqlData(user.userID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
