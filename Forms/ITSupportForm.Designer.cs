namespace ITHelpDeskTeamB
{
    partial class ITSupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITSupportForm));
            label1 = new Label();
            btnLogout = new Button();
            btnSolveTicket = new Button();
            btnShareTicket = new Button();
            btnMyTickets = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 315);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 18);
            label1.TabIndex = 5;
            label1.Text = "Logged in as: *SUPPORT MEMBER*";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(599, 308);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(91, 22);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSolveTicket
            // 
            btnSolveTicket.BackColor = Color.Transparent;
            btnSolveTicket.BackgroundImage = (Image)resources.GetObject("btnSolveTicket.BackgroundImage");
            btnSolveTicket.BackgroundImageLayout = ImageLayout.Zoom;
            btnSolveTicket.FlatStyle = FlatStyle.Flat;
            btnSolveTicket.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            btnSolveTicket.Location = new Point(84, 92);
            btnSolveTicket.Margin = new Padding(3, 2, 3, 2);
            btnSolveTicket.Name = "btnSolveTicket";
            btnSolveTicket.Size = new Size(142, 124);
            btnSolveTicket.TabIndex = 7;
            btnSolveTicket.Text = "Solve Ticket";
            btnSolveTicket.TextAlign = ContentAlignment.BottomCenter;
            btnSolveTicket.UseVisualStyleBackColor = false;
            btnSolveTicket.Click += btnSolveTicket_Click;
            // 
            // btnShareTicket
            // 
            btnShareTicket.BackColor = Color.Transparent;
            btnShareTicket.BackgroundImage = (Image)resources.GetObject("btnShareTicket.BackgroundImage");
            btnShareTicket.BackgroundImageLayout = ImageLayout.Zoom;
            btnShareTicket.FlatStyle = FlatStyle.Flat;
            btnShareTicket.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            btnShareTicket.Location = new Point(273, 92);
            btnShareTicket.Margin = new Padding(3, 2, 3, 2);
            btnShareTicket.Name = "btnShareTicket";
            btnShareTicket.Size = new Size(142, 124);
            btnShareTicket.TabIndex = 8;
            btnShareTicket.Text = "Share Ticket";
            btnShareTicket.TextAlign = ContentAlignment.BottomCenter;
            btnShareTicket.UseVisualStyleBackColor = false;
            btnShareTicket.Click += btnShareTicket_Click;
            // 
            // btnMyTickets
            // 
            btnMyTickets.BackColor = Color.Transparent;
            btnMyTickets.BackgroundImage = (Image)resources.GetObject("btnMyTickets.BackgroundImage");
            btnMyTickets.BackgroundImageLayout = ImageLayout.Zoom;
            btnMyTickets.FlatStyle = FlatStyle.Flat;
            btnMyTickets.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            btnMyTickets.Location = new Point(466, 92);
            btnMyTickets.Margin = new Padding(3, 2, 3, 2);
            btnMyTickets.Name = "btnMyTickets";
            btnMyTickets.Size = new Size(142, 124);
            btnMyTickets.TabIndex = 9;
            btnMyTickets.Text = "My Tickets";
            btnMyTickets.TextAlign = ContentAlignment.BottomCenter;
            btnMyTickets.UseVisualStyleBackColor = false;
            btnMyTickets.Click += btnMyTickets_Click;
            // 
            // ITSupportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnMyTickets);
            Controls.Add(btnShareTicket);
            Controls.Add(btnSolveTicket);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ITSupportForm";
            Text = "IT Support System [Support View]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnSolveTicket;
        private Button btnShareTicket;
        private Button btnMyTickets;
    }
}