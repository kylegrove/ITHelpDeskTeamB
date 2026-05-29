namespace ITHelpDeskTeamB.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            btnReport = new Button();
            btnViewTickets = new Button();
            lblLoginUser = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Transparent;
            btnReport.BackgroundImage = (Image)resources.GetObject("btnReport.BackgroundImage");
            btnReport.BackgroundImageLayout = ImageLayout.Zoom;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Location = new Point(85, 62);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(134, 127);
            btnReport.TabIndex = 0;
            btnReport.Text = "Generate Report";
            btnReport.TextAlign = ContentAlignment.BottomCenter;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnViewTickets
            // 
            btnViewTickets.BackColor = Color.Transparent;
            btnViewTickets.BackgroundImage = (Image)resources.GetObject("btnViewTickets.BackgroundImage");
            btnViewTickets.BackgroundImageLayout = ImageLayout.Zoom;
            btnViewTickets.FlatStyle = FlatStyle.Flat;
            btnViewTickets.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewTickets.Location = new Point(301, 62);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(134, 127);
            btnViewTickets.TabIndex = 1;
            btnViewTickets.Text = "View All Tickets";
            btnViewTickets.TextAlign = ContentAlignment.BottomCenter;
            btnViewTickets.UseVisualStyleBackColor = false;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginUser.Location = new Point(12, 272);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(134, 18);
            lblLoginUser.TabIndex = 2;
            lblLoginUser.Text = "Logged in as: USERNAME";
            lblLoginUser.Click += lblLoginUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(438, 270);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 305);
            Controls.Add(btnLogout);
            Controls.Add(lblLoginUser);
            Controls.Add(btnViewTickets);
            Controls.Add(btnReport);
            Name = "ReportForm";
            Text = "IT Support System [Reports View]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReport;
        private Button btnViewTickets;
        private Label lblLoginUser;
        private Button btnLogout;
    }
}