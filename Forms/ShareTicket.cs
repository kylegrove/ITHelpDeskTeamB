using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHelpDeskTeamB
{
    public partial class ShareTicketForm : Form
    {
        private TicketDatabaseManager ticketDB;
        private UserDatabaseManager userDB;
        private User currentUser;

        public ShareTicketForm()
        {
            InitializeComponent();
            ticketDB = new TicketDatabaseManager();
            userDB = new UserDatabaseManager();
            LoadTickets();
            LoadITStaffMembers();
            ClearTicketDetails();
        }

        /// <summary>
        /// Constructor that accepts the current logged-in user
        /// </summary>
        public ShareTicketForm(User loggedInUser)
        {
            InitializeComponent();
            currentUser = loggedInUser;
            ticketDB = new TicketDatabaseManager();
            userDB = new UserDatabaseManager();
            LoadTickets();
            LoadITStaffMembers();
            ClearTicketDetails();
        }

        #region Load Data Methods

        /// <summary>
        /// Loads all tickets that can be shared
        /// </summary>
        private void LoadTickets()
        {
            listView1.Items.Clear();

            try
            {
                // Load tickets from database
                DataTable tickets = ticketDB.LoadAdminTickets();

                if (tickets != null && tickets.Rows.Count > 0)
                {
                    foreach (DataRow row in tickets.Rows)
                    {
                        string caseNum = row["ticketID"].ToString();

                        // Calculate age from ticketDate
                        DateTime ticketDate = Convert.ToDateTime(row["ticketDate"]);
                        TimeSpan age = DateTime.Now - ticketDate;
                        string ageDisplay = GetAgeDisplay(age);

                        // Get priority level
                        string priority = GetPriorityText(Convert.ToInt32(row["ticketPriority"]));

                        string status = row["ticketStatus"].ToString();

                        // Get assigned user (for now showing userID, could be enhanced to show name)
                        string assignedTo = row["userID"].ToString();

                        AddTicketToList(caseNum, ageDisplay, priority, status, assignedTo);
                    }
                }
                else
                {
                    // Show sample data if no tickets exist
                    AddSampleTicket("CASE-001", "2 days", "High", "Open", "Unassigned");
                    AddSampleTicket("CASE-002", "5 hours", "Critical", "In Progress", "john.doe@company.com");
                    AddSampleTicket("CASE-003", "1 day", "Medium", "Open", "jane.smith@company.com");
                    if (currentUser != null)
                    {
                        AddSampleTicket("CASE-004", "8 hours", "High", "In Progress", currentUser.userEmail);
                    }
                    AddSampleTicket("CASE-005", "3 days", "Low", "Open", "Unassigned");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Helper method to convert age TimeSpan to display string
        /// </summary>
        private string GetAgeDisplay(TimeSpan age)
        {
            if (age.TotalHours < 24)
            {
                return $"{(int)age.TotalHours} hours";
            }
            else
            {
                return $"{(int)age.TotalDays} days";
            }
        }

        /// <summary>
        /// Helper method to convert priority number to text
        /// </summary>
        private string GetPriorityText(int priority)
        {
            switch (priority)
            {
                case 1:
                    return "Low";
                case 2:
                    return "Medium";
                case 3:
                    return "High";
                case 4:
                    return "Critical";
                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// Helper method to add tickets to ListView
        /// </summary>
        private void AddTicketToList(string caseNum, string age, string priority, string status, string assignedTo)
        {
            ListViewItem item = new ListViewItem(caseNum);
            item.SubItems.Add(age);
            item.SubItems.Add(priority);
            item.SubItems.Add(status);
            item.SubItems.Add(assignedTo);
            listView1.Items.Add(item);
        }

        /// <summary>
        /// Helper method to add sample tickets to ListView
        /// </summary>
        private void AddSampleTicket(string caseNum, string age, string priority, string status, string assignedTo)
        {
            AddTicketToList(caseNum, age, priority, status, assignedTo);
        }

        /// <summary>
        /// Loads IT staff members into the dropdown
        /// </summary>
        private void LoadITStaffMembers()
        {
            cmbShareWith.Items.Clear();

            try
            {
                // Get all IT Support Members from UserDatabaseManager
                List<ITSupportMember> supportMembers = userDB.GetITSupportMembers();

                foreach (ITSupportMember staff in supportMembers)
                {
                    cmbShareWith.Items.Add(staff);
                }

                // Set display member to show names in dropdown
                cmbShareWith.DisplayMember = "userName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading IT staff: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles ticket selection from the list
        /// </summary>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Populate ticket details
                txtCaseNumber.Text = selectedItem.SubItems[0].Text;
                txtAge.Text = selectedItem.SubItems[1].Text;
                txtPriority.Text = selectedItem.SubItems[2].Text;
                txtStatus.Text = selectedItem.SubItems[3].Text;
                txtCurrentAssignee.Text = selectedItem.SubItems[4].Text;

                // Load full ticket details from database using TicketDatabaseManager
                try
                {
                    string description = ticketDB.GetTicketDescription(txtCaseNumber.Text);

                    if (!string.IsNullOrEmpty(description))
                    {
                        txtDescription.Text = description;
                    }
                    else
                    {
                        // Fallback to sample description
                        txtDescription.Text = $"Sample description for {txtCaseNumber.Text}\n\n" +
                            "User experiencing network connectivity issues. " +
                            "Unable to access shared drives and email intermittently.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading ticket description: {ex.Message}",
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    // Use sample description on error
                    txtDescription.Text = $"Sample description for {txtCaseNumber.Text}\n\n" +
                        "User experiencing network connectivity issues. " +
                        "Unable to access shared drives and email intermittently.";
                }

                // Enable share button
                btnShareTicket.Enabled = true;

                // Clear share fields
                cmbShareWith.SelectedIndex = -1;
                txtShareNote.Clear();
            }
            else
            {
                ClearTicketDetails();
            }
        }

        /// <summary>
        /// Handles the Share Ticket button click
        /// </summary>
        private void btnShareTicket_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtCaseNumber.Text))
            {
                MessageBox.Show("Please select a ticket from the list.",
                    "No Ticket Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbShareWith.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an IT staff member to share with.",
                    "No Recipient Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbShareWith.Focus();
                return;
            }

            ITSupportMember selectedStaff = (ITSupportMember)cmbShareWith.SelectedItem;

            // Check if trying to share with current assignee
            if (txtCurrentAssignee.Text == selectedStaff.userEmail ||
                txtCurrentAssignee.Text == selectedStaff.getUserID().ToString())
            {
                MessageBox.Show("This ticket is already assigned to the selected person.",
                    "Already Assigned",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Build confirmation message
            string action = chkReassign.Checked ? "reassign" : "share";
            string confirmMessage = $"Are you sure you want to {action} ticket {txtCaseNumber.Text} with {selectedStaff.userName}?";

            if (chkNotifyByEmail.Checked)
                confirmMessage += "\n\nAn email notification will be sent.";

            DialogResult result = MessageBox.Show(
                confirmMessage,
                "Confirm Share Ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Update ticket assignment in database using TicketDatabaseManager
                    string newStatus = chkReassign.Checked ? "Assigned" : txtStatus.Text;
                    bool success = ticketDB.ShareTicket(txtCaseNumber.Text, selectedStaff.getUserID(), newStatus);

                    if (success)
                    {
                        string actionCompleted = chkReassign.Checked ? "reassigned to" : "shared with";
                        MessageBox.Show(
                            $"Ticket {txtCaseNumber.Text} has been {actionCompleted} {selectedStaff.userName}!",
                            "Share Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // TODO: If email notification is enabled, send email
                        if (chkNotifyByEmail.Checked)
                        {
                            // SendEmailNotification(selectedStaff, txtCaseNumber.Text, txtShareNote.Text);
                            MessageBox.Show("Email notification feature not yet implemented.",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                        // Refresh the list and clear details
                        LoadTickets();
                        ClearTicketDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to share ticket. Please try again.",
                            "Share Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sharing ticket: {ex.Message}",
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTickets();
            LoadITStaffMembers();
            ClearTicketDetails();
            MessageBox.Show("Ticket list refreshed.",
                "Refresh Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTicketDetails()
        {
            txtCaseNumber.Clear();
            txtAge.Clear();
            txtPriority.Clear();
            txtStatus.Clear();
            txtCurrentAssignee.Clear();
            txtDescription.Clear();
            cmbShareWith.SelectedIndex = -1;
            txtShareNote.Clear();
            chkNotifyByEmail.Checked = true;
            chkReassign.Checked = false;
            btnShareTicket.Enabled = false;
        }

        #endregion
    }
}