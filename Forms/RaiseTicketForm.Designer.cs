namespace ITHelpDeskTeamB
{
    partial class RaiseTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaiseTicketForm));
            lbl_Department = new Label();
            lbl_Describe = new Label();
            txt_Describe = new TextBox();
            lbl_DateTime = new Label();
            dtp_DateTime = new DateTimePicker();
            lbl_Urgency = new Label();
            btn_Submit = new Button();
            com_Department = new ComboBox();
            comboBox2 = new ComboBox();
            lbl_Category = new Label();
            nud_Urgency = new NumericUpDown();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Urgency).BeginInit();
            SuspendLayout();
            // 
            // lbl_Department
            // 
            lbl_Department.AutoSize = true;
            lbl_Department.BackColor = Color.Transparent;
            lbl_Department.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Department.Location = new Point(11, 69);
            lbl_Department.Margin = new Padding(2, 0, 2, 0);
            lbl_Department.Name = "lbl_Department";
            lbl_Department.Size = new Size(79, 18);
            lbl_Department.TabIndex = 5;
            lbl_Department.Text = "Department";
            // 
            // lbl_Describe
            // 
            lbl_Describe.AutoSize = true;
            lbl_Describe.BackColor = Color.Transparent;
            lbl_Describe.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Describe.Location = new Point(11, 255);
            lbl_Describe.Margin = new Padding(2, 0, 2, 0);
            lbl_Describe.Name = "lbl_Describe";
            lbl_Describe.Size = new Size(113, 18);
            lbl_Describe.TabIndex = 13;
            lbl_Describe.Text = "Describe the issue:";
            // 
            // txt_Describe
            // 
            txt_Describe.Location = new Point(11, 277);
            txt_Describe.Margin = new Padding(2, 3, 2, 3);
            txt_Describe.Multiline = true;
            txt_Describe.Name = "txt_Describe";
            txt_Describe.ScrollBars = ScrollBars.Vertical;
            txt_Describe.Size = new Size(681, 155);
            txt_Describe.TabIndex = 14;
            // 
            // lbl_DateTime
            // 
            lbl_DateTime.AutoSize = true;
            lbl_DateTime.BackColor = Color.Transparent;
            lbl_DateTime.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DateTime.Location = new Point(191, 69);
            lbl_DateTime.Margin = new Padding(2, 0, 2, 0);
            lbl_DateTime.Name = "lbl_DateTime";
            lbl_DateTime.Size = new Size(93, 18);
            lbl_DateTime.TabIndex = 18;
            lbl_DateTime.Text = "Date and Time";
            // 
            // dtp_DateTime
            // 
            dtp_DateTime.Location = new Point(191, 91);
            dtp_DateTime.Margin = new Padding(2, 3, 2, 3);
            dtp_DateTime.Name = "dtp_DateTime";
            dtp_DateTime.Size = new Size(271, 23);
            dtp_DateTime.TabIndex = 19;
            // 
            // lbl_Urgency
            // 
            lbl_Urgency.AutoSize = true;
            lbl_Urgency.BackColor = Color.Transparent;
            lbl_Urgency.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Urgency.Location = new Point(11, 187);
            lbl_Urgency.Margin = new Padding(2, 0, 2, 0);
            lbl_Urgency.Name = "lbl_Urgency";
            lbl_Urgency.Size = new Size(205, 18);
            lbl_Urgency.TabIndex = 21;
            lbl_Urgency.Text = "Urgency (5 being the most urgent)";
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(591, 459);
            btn_Submit.Margin = new Padding(2, 3, 2, 3);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(101, 27);
            btn_Submit.TabIndex = 22;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // com_Department
            // 
            com_Department.FormattingEnabled = true;
            com_Department.Items.AddRange(new object[] { "HR", "IT", "Sales", "Management", "Other" });
            com_Department.Location = new Point(11, 91);
            com_Department.Margin = new Padding(2, 3, 2, 3);
            com_Department.Name = "com_Department";
            com_Department.Size = new Size(164, 23);
            com_Department.TabIndex = 23;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Software", "Hardware", "Internet", "Authorization", "Other" });
            comboBox2.Location = new Point(11, 152);
            comboBox2.Margin = new Padding(2, 3, 2, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 25;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.BackColor = Color.Transparent;
            lbl_Category.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Category.Location = new Point(11, 131);
            lbl_Category.Margin = new Padding(2, 0, 2, 0);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(60, 18);
            lbl_Category.TabIndex = 24;
            lbl_Category.Text = "Category";
            // 
            // nud_Urgency
            // 
            nud_Urgency.Location = new Point(12, 208);
            nud_Urgency.Margin = new Padding(2, 3, 2, 3);
            nud_Urgency.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_Urgency.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Urgency.Name = "nud_Urgency";
            nud_Urgency.Size = new Size(162, 23);
            nud_Urgency.TabIndex = 26;
            nud_Urgency.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Gill Sans MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(5, 12);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 38);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "Create New Ticket";
            // 
            // RaiseTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(720, 499);
            Controls.Add(lblTitle);
            Controls.Add(nud_Urgency);
            Controls.Add(comboBox2);
            Controls.Add(lbl_Category);
            Controls.Add(com_Department);
            Controls.Add(btn_Submit);
            Controls.Add(lbl_Urgency);
            Controls.Add(dtp_DateTime);
            Controls.Add(lbl_DateTime);
            Controls.Add(txt_Describe);
            Controls.Add(lbl_Describe);
            Controls.Add(lbl_Department);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RaiseTicketForm";
            Text = "Create Ticket";
            ((System.ComponentModel.ISupportInitialize)nud_Urgency).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Department;
        private DateTimePicker DTP_DateTime;
        private Label lbl_Describe;
        private TextBox txt_Describe;
        private Label lbl_Urgency;
        private Label lbl_DateTime;
        private DateTimePicker dtp_DateTime;
        private Button btn_Submit;
		private ComboBox com_Department;
		private ComboBox comboBox2;
		private Label lbl_Category;
		private NumericUpDown nud_Urgency;
        private Label lblTitle;
    }
}
