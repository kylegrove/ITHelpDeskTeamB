using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHelpDeskTeamB
{
    public partial class OnlineHelpForm : Form
    {
        public OnlineHelpForm()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.comptia.org/en-us/blog/use-a-troubleshooting-methodology-for-more-efficient-it-support/",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://ccitraining.edu/blog/steps-to-troubleshooting-almost-any-it-issue/",
                UseShellExecute = true
            });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://erieit.edu/10-common-problems-of-computer-hardware/",
                UseShellExecute = true
            });
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
