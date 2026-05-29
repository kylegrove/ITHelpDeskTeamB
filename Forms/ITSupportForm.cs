using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHelpDeskTeamB
{
    public partial class ITSupportForm : Form
    {
        private string username;
        public ITSupportForm(string username)
        {
            InitializeComponent();
            this.username = username;
            label1.Text = "Logged in as " + username + " (Support Team)";
        }

        private void btnSolveTicket_Click(object sender, EventArgs e)
        {
            SolveTicket SolveTicketForm = new SolveTicket();
            SolveTicketForm.Show();
            this.Hide();
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            MyTickets mytickets = new MyTickets(username);
            mytickets.Show();
            this.Hide();
        }

        private void btnShareTicket_Click(object sender, EventArgs e)
        {
            ShareTicketForm shareTicket = new ShareTicketForm();
            shareTicket.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
