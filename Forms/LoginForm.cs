using ITHelpDeskTeamB.Forms;
using Microsoft.Data.SqlClient;  //this using directive is for access to the sqlServer
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHelpDeskTeamB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            UserDatabaseManager userDatabasemanager = new UserDatabaseManager();
            User user;
            try
            {
                if (enteredPassword == userDatabasemanager.getAuthorizedPassword(txtUsername.Text))
                {
                    user = userDatabasemanager.GetUser(txtUsername.Text);

                    if (user.userType == "member")
                    {
                        MemberForm memberForm = new MemberForm(txtUsername.Text);
                        memberForm.Show();
                        this.Hide();
                    }
                    else if (user.userType == "admin")
                    {
                        AdminForm adminForm = new AdminForm(txtUsername.Text);
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (user.userType == "support")
                    {
                        ITSupportForm supportForm = new ITSupportForm(txtUsername.Text);
                        supportForm.Show();
                        this.Hide();
                    }
                    else if (user.userType == "report")
                    {
                        ReportForm reportForm = new ReportForm(txtUsername.Text);
                        reportForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Successfully logged in. However, the system could not determine your user type. Contact the IT admin for further assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry. Invalid User Name and/or Password. Try again.", "Warning!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning from Login Attempt!");
            }
        }
    }
}
