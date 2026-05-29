using Microsoft.Data.SqlClient;
using System.Data;

namespace ITHelpDeskTeamB
{
    public partial class AdminViewTicketForm : Form
    {
        TicketDatabaseManager dbManager;
        public AdminViewTicketForm()
        {
            InitializeComponent();
            dbManager = new TicketDatabaseManager();
            dataGridView1.DataSource = dbManager.LoadAdminTickets();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
