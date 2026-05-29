namespace ITHelpDeskTeamB
{
    partial class MemberForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            btnHelp = new Button();
            btnNewTicket = new Button();
            btnExisting = new Button();
            btnTickets = new Button();
            label1 = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.Transparent;
            btnHelp.BackgroundImage = (Image)resources.GetObject("btnHelp.BackgroundImage");
            btnHelp.BackgroundImageLayout = ImageLayout.Zoom;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Location = new Point(499, 64);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(143, 142);
            btnHelp.TabIndex = 0;
            btnHelp.Text = "Online Help";
            btnHelp.TextAlign = ContentAlignment.BottomCenter;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnNewTicket
            // 
            btnNewTicket.BackColor = Color.Transparent;
            btnNewTicket.BackgroundImage = (Image)resources.GetObject("btnNewTicket.BackgroundImage");
            btnNewTicket.BackgroundImageLayout = ImageLayout.Zoom;
            btnNewTicket.FlatStyle = FlatStyle.Flat;
            btnNewTicket.Location = new Point(70, 64);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.Size = new Size(143, 142);
            btnNewTicket.TabIndex = 1;
            btnNewTicket.Text = "New Ticket";
            btnNewTicket.TextAlign = ContentAlignment.BottomCenter;
            btnNewTicket.UseVisualStyleBackColor = false;
            btnNewTicket.Click += btnNewTicket_Click;
            // 
            // btnExisting
            // 
            btnExisting.BackColor = Color.Transparent;
            btnExisting.BackgroundImage = (Image)resources.GetObject("btnExisting.BackgroundImage");
            btnExisting.BackgroundImageLayout = ImageLayout.Zoom;
            btnExisting.Enabled = false;
            btnExisting.FlatStyle = FlatStyle.Flat;
            btnExisting.Location = new Point(329, 212);
            btnExisting.Name = "btnExisting";
            btnExisting.Size = new Size(165, 168);
            btnExisting.TabIndex = 2;
            btnExisting.Text = "View Existing Issues";
            btnExisting.TextAlign = ContentAlignment.BottomCenter;
            btnExisting.UseVisualStyleBackColor = false;
            btnExisting.Visible = false;
            btnExisting.Click += btnExisting_Click;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = Color.Transparent;
            btnTickets.BackgroundImage = (Image)resources.GetObject("btnTickets.BackgroundImage");
            btnTickets.BackgroundImageLayout = ImageLayout.Zoom;
            btnTickets.FlatStyle = FlatStyle.Flat;
            btnTickets.Location = new Point(286, 64);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(143, 142);
            btnTickets.TabIndex = 3;
            btnTickets.Text = "My Tickets";
            btnTickets.TextAlign = ContentAlignment.BottomCenter;
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 266);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 4;
            label1.Text = "Logged in as: panos";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(606, 261);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(104, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 314);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(btnTickets);
            Controls.Add(btnExisting);
            Controls.Add(btnNewTicket);
            Controls.Add(btnHelp);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MemberForm";
            Text = "IT Support System - Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHelp;
        private Button btnNewTicket;
        private Button btnExisting;
        private Button btnTickets;
        private Label label1;
        private Button btnLogout;
    }
}
