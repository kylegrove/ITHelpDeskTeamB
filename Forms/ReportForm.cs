using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHelpDeskTeamB.Forms
{
    public partial class ReportForm : Form
    {
        private string username;
        public ReportForm(string username)
        {
            InitializeComponent();
            this.username = username;
            lblLoginUser.Text = "Logged in as " + username + " (Report Manager)";
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            AdminViewTicketForm ticket = new AdminViewTicketForm();
            ticket.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GenerateReport rpf = new GenerateReport();
            rpf.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblLoginUser_Click(object sender, EventArgs e)
        {

        }
    }
}
