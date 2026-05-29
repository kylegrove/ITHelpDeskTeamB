namespace ITHelpDeskTeamB
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            btnUserMgmt = new Button();
            btnReports = new Button();
            lblUsername = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnUserMgmt
            // 
            btnUserMgmt.BackColor = Color.Transparent;
            btnUserMgmt.BackgroundImage = (Image)resources.GetObject("btnUserMgmt.BackgroundImage");
            btnUserMgmt.BackgroundImageLayout = ImageLayout.Zoom;
            btnUserMgmt.FlatStyle = FlatStyle.Flat;
            btnUserMgmt.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserMgmt.Location = new Point(98, 97);
            btnUserMgmt.Margin = new Padding(2);
            btnUserMgmt.Name = "btnUserMgmt";
            btnUserMgmt.Size = new Size(139, 117);
            btnUserMgmt.TabIndex = 0;
            btnUserMgmt.Text = "User Management";
            btnUserMgmt.TextAlign = ContentAlignment.BottomCenter;
            btnUserMgmt.UseVisualStyleBackColor = false;
            btnUserMgmt.Click += button1_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.BackgroundImage = (Image)resources.GetObject("btnReports.BackgroundImage");
            btnReports.BackgroundImageLayout = ImageLayout.Zoom;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(314, 97);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(139, 117);
            btnReports.TabIndex = 1;
            btnReports.Text = "View All Tickets";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(10, 309);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(152, 18);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Logged in as: panos [ADMIN]";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(460, 301);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 22);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 331);
            Controls.Add(btnLogout);
            Controls.Add(lblUsername);
            Controls.Add(btnReports);
            Controls.Add(btnUserMgmt);
            Margin = new Padding(2);
            Name = "AdminForm";
            Text = "IT Support System [Admin View]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserMgmt;
        private Button btnReports;
        private Label lblUsername;
        private Button btnLogout;
    }
}