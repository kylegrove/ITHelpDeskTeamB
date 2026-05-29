using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ITHelpDeskTeamB
{
    partial class SolveTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolveTicket));
            label1 = new Label();
            listView1 = new ListView();
            CaseHeader = new ColumnHeader();
            AgeHeader = new ColumnHeader();
            PriorityHeader = new ColumnHeader();
            StatusHeader = new ColumnHeader();
            groupBoxDetails = new GroupBox();
            txtNotes = new TextBox();
            lblNotes = new Label();
            txtSolution = new TextBox();
            lblSolution = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            cmbPriority = new ComboBox();
            lblPriority = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtCaseNumber = new TextBox();
            lblCaseNumber = new Label();
            btnSolveTicket = new Button();
            btnSaveChanges = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            groupBoxDetails.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "Open Tickets List:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CaseHeader, AgeHeader, PriorityHeader, StatusHeader });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(26, 46);
            listView1.Name = "listView1";
            listView1.Size = new Size(748, 180);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // CaseHeader
            // 
            CaseHeader.Text = "Case Number";
            CaseHeader.Width = 150;
            // 
            // AgeHeader
            // 
            AgeHeader.Text = "Age";
            AgeHeader.Width = 100;
            // 
            // PriorityHeader
            // 
            PriorityHeader.Text = "Priority";
            PriorityHeader.Width = 100;
            // 
            // StatusHeader
            // 
            StatusHeader.Text = "Status";
            StatusHeader.Width = 120;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.BackColor = Color.Transparent;
            groupBoxDetails.Controls.Add(txtNotes);
            groupBoxDetails.Controls.Add(lblNotes);
            groupBoxDetails.Controls.Add(txtSolution);
            groupBoxDetails.Controls.Add(lblSolution);
            groupBoxDetails.Controls.Add(txtDescription);
            groupBoxDetails.Controls.Add(lblDescription);
            groupBoxDetails.Controls.Add(cmbPriority);
            groupBoxDetails.Controls.Add(lblPriority);
            groupBoxDetails.Controls.Add(txtAge);
            groupBoxDetails.Controls.Add(lblAge);
            groupBoxDetails.Controls.Add(txtCaseNumber);
            groupBoxDetails.Controls.Add(lblCaseNumber);
            groupBoxDetails.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDetails.Location = new Point(26, 240);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(748, 360);
            groupBoxDetails.TabIndex = 2;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Ticket Details";
            // 
            // txtNotes
            // 
            txtNotes.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(120, 285);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(610, 70);
            txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(15, 285);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 21);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Notes:";
            // 
            // txtSolution
            // 
            txtSolution.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSolution.Location = new Point(120, 175);
            txtSolution.Multiline = true;
            txtSolution.Name = "txtSolution";
            txtSolution.ScrollBars = ScrollBars.Vertical;
            txtSolution.Size = new Size(610, 90);
            txtSolution.TabIndex = 9;
            // 
            // lblSolution
            // 
            lblSolution.AutoSize = true;
            lblSolution.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSolution.Location = new Point(15, 175);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(63, 21);
            lblSolution.TabIndex = 8;
            lblSolution.Text = "Solution:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(120, 105);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(610, 55);
            txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(15, 108);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 21);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // cmbPriority
            // 
            cmbPriority.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cmbPriority.Location = new Point(120, 72);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 29);
            cmbPriority.TabIndex = 5;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(15, 75);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(59, 21);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority:";
            // 
            // txtAge
            // 
            txtAge.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(530, 39);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(200, 25);
            txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(425, 42);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 21);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // txtCaseNumber
            // 
            txtCaseNumber.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaseNumber.Location = new Point(120, 39);
            txtCaseNumber.Name = "txtCaseNumber";
            txtCaseNumber.ReadOnly = true;
            txtCaseNumber.Size = new Size(200, 25);
            txtCaseNumber.TabIndex = 1;
            // 
            // lblCaseNumber
            // 
            lblCaseNumber.AutoSize = true;
            lblCaseNumber.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaseNumber.Location = new Point(15, 42);
            lblCaseNumber.Name = "lblCaseNumber";
            lblCaseNumber.Size = new Size(99, 21);
            lblCaseNumber.TabIndex = 0;
            lblCaseNumber.Text = "Case Number:";
            // 
            // btnSolveTicket
            // 
            btnSolveTicket.BackColor = Color.FromArgb(0, 122, 204);
            btnSolveTicket.FlatStyle = FlatStyle.Flat;
            btnSolveTicket.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolveTicket.ForeColor = Color.White;
            btnSolveTicket.Location = new Point(480, 616);
            btnSolveTicket.Name = "btnSolveTicket";
            btnSolveTicket.Size = new Size(140, 35);
            btnSolveTicket.TabIndex = 3;
            btnSolveTicket.Text = "Solve Ticket";
            btnSolveTicket.UseVisualStyleBackColor = false;
            btnSolveTicket.Click += btnSolveTicket_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(0, 122, 204);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(172, 616);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(140, 35);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(634, 616);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(224, 224, 224);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(26, 616);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 35);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // SolveTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 662);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnSolveTicket);
            Controls.Add(groupBoxDetails);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "SolveTicket";
            Text = "Solve Ticket - IT Help Desk";
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
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
        private GroupBox groupBoxDetails;
        private TextBox txtCaseNumber;
        private Label lblCaseNumber;
        private TextBox txtAge;
        private Label lblAge;
        private ComboBox cmbPriority;
        private Label lblPriority;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtNotes;
        private Label lblNotes;
        private TextBox txtSolution;
        private Label lblSolution;
        private Button btnSolveTicket;
        private Button btnClose;
        private Button btnRefresh;
        private Button btnSaveChanges;
    }
}