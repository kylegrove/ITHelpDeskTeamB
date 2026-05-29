using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITHelpDeskTeamB.Forms
{
    public partial class GenerateReport : Form
    {
        TicketDatabaseManager tdm = new TicketDatabaseManager();
        UserDatabaseManager udm = new UserDatabaseManager();
        int[] dataCount;
        int userCount;
        public GenerateReport()
        {
            InitializeComponent();
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            dataCount = tdm.GetDataCount();
            userCount = udm.getUserCount();
            int ticketsOpen = dataCount[0] + dataCount[1];
            listView2.Items[0].SubItems[1].Text = Convert.ToString(ticketsOpen);
            listView2.Items[2].SubItems[1].Text = Convert.ToString(dataCount[0]);
            listView2.Items[3].SubItems[1].Text = Convert.ToString(dataCount[1]);
            listView2.Items[4].SubItems[1].Text = Convert.ToString(dataCount[2]);
            listView2.Items[1].SubItems[1].Text = Convert.ToString(dataCount[3]);
            listView2.Items[5].SubItems[1].Text = Convert.ToString(userCount);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
