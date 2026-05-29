using static System.Net.Mime.MediaTypeNames;

namespace ITHelpDeskTeamB
{
    partial class ShareTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareTicketForm));
            label1 = new Label();
            listView1 = new ListView();
            CaseHeader = new ColumnHeader();
            AgeHeader = new ColumnHeader();
            PriorityHeader = new ColumnHeader();
            StatusHeader = new ColumnHeader();
            AssignedToHeader = new ColumnHeader();
            groupBoxDetails = new GroupBox();
            txtCurrentAssignee = new TextBox();
            lblCurrentAssignee = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtStatus = new TextBox();
            lblStatus = new Label();
            txtPriority = new TextBox();
            lblPriority = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtCaseNumber = new TextBox();
            lblCaseNumber = new Label();
            groupBoxShare = new GroupBox();
            chkReassign = new CheckBox();
            chkNotifyByEmail = new CheckBox();
            txtShareNote = new TextBox();
            lblShareNote = new Label();
            cmbShareWith = new ComboBox();
            lblShareWith = new Label();
            btnShareTicket = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            groupBoxDetails.SuspendLayout();
            groupBoxShare.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "Available Tickets List:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CaseHeader, AgeHeader, PriorityHeader, StatusHeader, AssignedToHeader });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(26, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(748, 160);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // CaseHeader
            // 
            CaseHeader.Text = "Case Number";
            CaseHeader.Width = 130;
            // 
            // AgeHeader
            // 
            AgeHeader.Text = "Age";
            AgeHeader.Width = 90;
            // 
            // PriorityHeader
            // 
            PriorityHeader.Text = "Priority";
            PriorityHeader.Width = 90;
            // 
            // StatusHeader
            // 
            StatusHeader.Text = "Status";
            StatusHeader.Width = 110;
            // 
            // AssignedToHeader
            // 
            AssignedToHeader.Text = "Assigned To";
            AssignedToHeader.Width = 150;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.BackColor = Color.Transparent;
            groupBoxDetails.Controls.Add(txtCurrentAssignee);
            groupBoxDetails.Controls.Add(lblCurrentAssignee);
            groupBoxDetails.Controls.Add(txtDescription);
            groupBoxDetails.Controls.Add(lblDescription);
            groupBoxDetails.Controls.Add(txtStatus);
            groupBoxDetails.Controls.Add(lblStatus);
            groupBoxDetails.Controls.Add(txtPriority);
            groupBoxDetails.Controls.Add(lblPriority);
            groupBoxDetails.Controls.Add(txtAge);
            groupBoxDetails.Controls.Add(lblAge);
            groupBoxDetails.Controls.Add(txtCaseNumber);
            groupBoxDetails.Controls.Add(lblCaseNumber);
            groupBoxDetails.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDetails.Location = new Point(26, 255);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(748, 180);
            groupBoxDetails.TabIndex = 2;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Ticket Details";
            // 
            // txtCurrentAssignee
            // 
            txtCurrentAssignee.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentAssignee.Location = new Point(530, 100);
            txtCurrentAssignee.Name = "txtCurrentAssignee";
            txtCurrentAssignee.ReadOnly = true;
            txtCurrentAssignee.Size = new Size(200, 25);
            txtCurrentAssignee.TabIndex = 13;
            // 
            // lblCurrentAssignee
            // 
            lblCurrentAssignee.AutoSize = true;
            lblCurrentAssignee.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentAssignee.Location = new Point(425, 103);
            lblCurrentAssignee.Name = "lblCurrentAssignee";
            lblCurrentAssignee.Size = new Size(88, 21);
            lblCurrentAssignee.TabIndex = 12;
            lblCurrentAssignee.Text = "Assigned To:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(140, 100);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(590, 65);
            txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(15, 103);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 21);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description:";
            // 
            // txtStatus
            // 
            txtStatus.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(530, 67);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(200, 25);
            txtStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(425, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 21);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // txtPriority
            // 
            txtPriority.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriority.Location = new Point(140, 67);
            txtPriority.Name = "txtPriority";
            txtPriority.ReadOnly = true;
            txtPriority.Size = new Size(200, 25);
            txtPriority.TabIndex = 7;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(15, 70);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(59, 21);
            lblPriority.TabIndex = 6;
            lblPriority.Text = "Priority:";
            // 
            // txtAge
            // 
            txtAge.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(530, 34);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(200, 25);
            txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(425, 37);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 21);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age:";
            // 
            // txtCaseNumber
            // 
            txtCaseNumber.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaseNumber.Location = new Point(140, 34);
            txtCaseNumber.Name = "txtCaseNumber";
            txtCaseNumber.ReadOnly = true;
            txtCaseNumber.Size = new Size(200, 25);
            txtCaseNumber.TabIndex = 3;
            // 
            // lblCaseNumber
            // 
            lblCaseNumber.AutoSize = true;
            lblCaseNumber.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaseNumber.Location = new Point(15, 37);
            lblCaseNumber.Name = "lblCaseNumber";
            lblCaseNumber.Size = new Size(99, 21);
            lblCaseNumber.TabIndex = 2;
            lblCaseNumber.Text = "Case Number:";
            // 
            // groupBoxShare
            // 
            groupBoxShare.BackColor = Color.Transparent;
            groupBoxShare.Controls.Add(chkReassign);
            groupBoxShare.Controls.Add(chkNotifyByEmail);
            groupBoxShare.Controls.Add(txtShareNote);
            groupBoxShare.Controls.Add(lblShareNote);
            groupBoxShare.Controls.Add(cmbShareWith);
            groupBoxShare.Controls.Add(lblShareWith);
            groupBoxShare.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxShare.Location = new Point(26, 450);
            groupBoxShare.Name = "groupBoxShare";
            groupBoxShare.Size = new Size(748, 180);
            groupBoxShare.TabIndex = 3;
            groupBoxShare.TabStop = false;
            groupBoxShare.Text = "Share Ticket";
            // 
            // chkReassign
            // 
            chkReassign.AutoSize = true;
            chkReassign.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkReassign.Location = new Point(360, 140);
            chkReassign.Name = "chkReassign";
            chkReassign.Size = new Size(211, 25);
            chkReassign.TabIndex = 5;
            chkReassign.Text = "Reassign ticket to this person";
            chkReassign.UseVisualStyleBackColor = true;
            // 
            // chkNotifyByEmail
            // 
            chkNotifyByEmail.AutoSize = true;
            chkNotifyByEmail.Checked = true;
            chkNotifyByEmail.CheckState = CheckState.Checked;
            chkNotifyByEmail.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkNotifyByEmail.Location = new Point(140, 140);
            chkNotifyByEmail.Name = "chkNotifyByEmail";
            chkNotifyByEmail.Size = new Size(168, 25);
            chkNotifyByEmail.TabIndex = 4;
            chkNotifyByEmail.Text = "Send email notification";
            chkNotifyByEmail.UseVisualStyleBackColor = true;
            // 
            // txtShareNote
            // 
            txtShareNote.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShareNote.Location = new Point(140, 67);
            txtShareNote.Multiline = true;
            txtShareNote.Name = "txtShareNote";
            txtShareNote.ScrollBars = ScrollBars.Vertical;
            txtShareNote.Size = new Size(590, 60);
            txtShareNote.TabIndex = 3;
            // 
            // lblShareNote
            // 
            lblShareNote.AutoSize = true;
            lblShareNote.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShareNote.Location = new Point(15, 70);
            lblShareNote.Name = "lblShareNote";
            lblShareNote.Size = new Size(112, 21);
            lblShareNote.TabIndex = 2;
            lblShareNote.Text = "Note (Optional):";
            // 
            // cmbShareWith
            // 
            cmbShareWith.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShareWith.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbShareWith.FormattingEnabled = true;
            cmbShareWith.Location = new Point(140, 33);
            cmbShareWith.Name = "cmbShareWith";
            cmbShareWith.Size = new Size(300, 29);
            cmbShareWith.TabIndex = 1;
            // 
            // lblShareWith
            // 
            lblShareWith.AutoSize = true;
            lblShareWith.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShareWith.Location = new Point(15, 36);
            lblShareWith.Name = "lblShareWith";
            lblShareWith.Size = new Size(83, 21);
            lblShareWith.TabIndex = 0;
            lblShareWith.Text = "Share With:";
            // 
            // btnShareTicket
            // 
            btnShareTicket.BackColor = Color.FromArgb(0, 122, 204);
            btnShareTicket.Enabled = false;
            btnShareTicket.FlatStyle = FlatStyle.Flat;
            btnShareTicket.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShareTicket.ForeColor = Color.White;
            btnShareTicket.Location = new Point(480, 645);
            btnShareTicket.Name = "btnShareTicket";
            btnShareTicket.Size = new Size(140, 35);
            btnShareTicket.TabIndex = 4;
            btnShareTicket.Text = "Share Ticket";
            btnShareTicket.UseVisualStyleBackColor = false;
            btnShareTicket.Click += btnShareTicket_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(634, 645);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(224, 224, 224);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(26, 645);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 35);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(26, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 21);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Share Tickets with Team";
            // 
            // ShareTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 700);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnShareTicket);
            Controls.Add(groupBoxShare);
            Controls.Add(groupBoxDetails);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "ShareTicketForm";
            Text = "Share Ticket - IT Help Desk";
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            groupBoxShare.ResumeLayout(false);
            groupBoxShare.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader CaseHeader;
        private ColumnHeader AgeHeader;
        private ColumnHeader PriorityHeader;
        private ColumnHeader StatusHeader;
        private ColumnHeader AssignedToHeader;
        private GroupBox groupBoxDetails;
        private TextBox txtCaseNumber;
        private Label lblCaseNumber;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtPriority;
        private Label lblPriority;
        private TextBox txtStatus;
        private Label lblStatus;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtCurrentAssignee;
        private Label lblCurrentAssignee;
        private GroupBox groupBoxShare;
        private ComboBox cmbShareWith;
        private Label lblShareWith;
        private TextBox txtShareNote;
        private Label lblShareNote;
        private CheckBox chkNotifyByEmail;
        private CheckBox chkReassign;
        private Button btnShareTicket;
        private Button btnClose;
        private Button btnRefresh;
        private Label lblTitle;
    }
}