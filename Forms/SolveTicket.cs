using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITHelpDeskTeamB
{
    public partial class SolveTicket : Form
    {
        private TicketDatabaseManager dbManager;
        StringConnection connectionString = new StringConnection();
        public SolveTicket()
        {
            InitializeComponent();
            LoadOpenTickets();
            ClearTicketDetails();
            dbManager = new TicketDatabaseManager();
        }

        // This method loads open tickets from the database
        private void LoadOpenTickets()
        {
            listView1.Items.Clear();

            try
            {
                DataTable tickets = dbManager.LoadAdminTickets();

                if (tickets != null && tickets.Rows.Count > 0)
                {
                    foreach (DataRow row in tickets.Rows)
                    {
                        // Only show tickets that are not solved
                        string status = row["ticketStatus"].ToString();
                        if (status != "Solved")
                        {
                            // Create list item with ticket ID
                            string ticketID = row["ticketID"].ToString();
                            ListViewItem item = new ListViewItem(ticketID);

                            // Calculate age from ticketDate
                            DateTime ticketDate = Convert.ToDateTime(row["ticketDate"]);
                            TimeSpan age = DateTime.Now - ticketDate;
                            string ageString;

                            if (age.TotalDays >= 1)
                            {
                                int days = (int)age.TotalDays;
                                ageString = days == 1 ? "1 day" : $"{days} days";
                            }
                            else if (age.TotalHours >= 1)
                            {
                                int hours = (int)age.TotalHours;
                                ageString = hours == 1 ? "1 hour" : $"{hours} hours";
                            }
                            else
                            {
                                int minutes = (int)age.TotalMinutes;
                                ageString = minutes <= 1 ? "1 minute" : $"{minutes} minutes";
                            }
                            item.SubItems.Add(ageString);

                            // Convert priority number to text
                            string priorityText = ConvertPriorityToText(row["ticketPriority"]);
                            item.SubItems.Add(priorityText);

                            // Add status
                            item.SubItems.Add(status);

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Helper method to convert priority number to text
        private string ConvertPriorityToText(object priority)
        {
            int priorityValue = Convert.ToInt32(priority);
            return priorityValue switch
            {
                1 => "Low",
                2 => "Medium",
                3 => "High",
                4 => "Critical",
                _ => "Medium"
            };
        }

        // Helper method to convert priority text to number
        private int ConvertPriorityToNumber(string priorityText)
        {
            return priorityText switch
            {
                "Low" => 1,
                "Medium" => 2,
                "High" => 3,
                "Critical" => 4,
                _ => 2
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Populate the detail fields with selected ticket information
                txtCaseNumber.Text = selectedItem.SubItems[0].Text;
                txtAge.Text = selectedItem.SubItems[1].Text;
                cmbPriority.Text = selectedItem.SubItems[2].Text;

                try
                {
                    // Load full ticket details from database
                    DataTable tickets = dbManager.LoadAdminTickets();
                    if (tickets != null)
                    {
                        string ticketID = txtCaseNumber.Text;
                        DataRow[] rows = tickets.Select($"ticketID = {ticketID}");

                        if (rows.Length > 0)
                        {
                            DataRow ticketRow = rows[0];
                            txtDescription.Text = ticketRow["ticketDescription"].ToString();

                            // Load existing solution if available
                            string existingSolution = ticketRow["ticketSolution"].ToString();
                            if (existingSolution != "N/A" && !string.IsNullOrWhiteSpace(existingSolution))
                            {
                                txtSolution.Text = existingSolution;
                            }
                            else
                            {
                                txtSolution.Text = ""; // Clear solution field for new entry
                            }
                        }
                        else
                        {
                            txtDescription.Text = "Description not available.";
                            txtSolution.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtDescription.Text = "Error loading ticket description: " + ex.Message;
                    txtSolution.Text = "";
                }

                txtNotes.Text = ""; // Clear notes field for new entry

                btnSolveTicket.Enabled = true;
                btnSaveChanges.Enabled = true;
            }
            else
            {
                ClearTicketDetails();
            }
        }

        private void btnSolveTicket_Click(object sender, EventArgs e)
        {
            // Validate that a ticket is selected and solution is provided
            if (string.IsNullOrWhiteSpace(txtCaseNumber.Text))
            {
                MessageBox.Show("Please select a ticket from the list.",
                    "No Ticket Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSolution.Text))
            {
                MessageBox.Show("Please enter a solution before solving the ticket.",
                    "Solution Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSolution.Focus();
                return;
            }

            // Confirm action
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to mark ticket {txtCaseNumber.Text} as solved?\n\n" +
                $"Solution: {txtSolution.Text.Substring(0, Math.Min(100, txtSolution.Text.Length))}...",
                "Confirm Solve Ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Update the ticket in the database
                dbManager.SolveTicket(txtCaseNumber.Text, txtSolution.Text);

                MessageBox.Show($"Ticket {txtCaseNumber.Text} has been marked as solved!",
                    "Ticket Solved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Refresh the ticket list and clear details
                LoadOpenTickets();
                ClearTicketDetails();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Validate that a ticket is selected
            if (string.IsNullOrWhiteSpace(txtCaseNumber.Text))
            {
                MessageBox.Show("Please select a ticket from the list.",
                    "No Ticket Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate priority is selected
            if (string.IsNullOrWhiteSpace(cmbPriority.Text))
            {
                MessageBox.Show("Please select a priority level.",
                    "Priority Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbPriority.Focus();
                return;
            }

            // Confirm action
            DialogResult result = MessageBox.Show(
                $"Save changes to ticket {txtCaseNumber.Text}?\n\n" +
                $"Priority: {cmbPriority.Text}\n" +
                $"Notes: {txtNotes.Text.Substring(0, Math.Min(50, txtNotes.Text.Length))}...",
                "Confirm Save Changes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Update the ticket in the database with new priority and notes
                    dbManager.UpdateTicketChanges(txtCaseNumber.Text, cmbPriority.Text, txtNotes.Text);

                    MessageBox.Show($"Changes to ticket {txtCaseNumber.Text} have been saved!",
                        "Changes Saved",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Refresh the ticket list
                    LoadOpenTickets();
                    ClearTicketDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving changes: {ex.Message}",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOpenTickets();
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
            cmbPriority.Text = "";
            txtDescription.Clear();
            txtSolution.Clear();
            txtNotes.Clear();
            btnSolveTicket.Enabled = false;
            btnSaveChanges.Enabled = false;
        }
    }
}