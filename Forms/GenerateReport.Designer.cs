namespace ITHelpDeskTeamB.Forms
{
    partial class GenerateReport
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Open Tickets", "0" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "-> Opened Today", "0" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "-> Unsolved", "0" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "-> In Progress", "0" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Closed Tickets", "0" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Users", "0" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReport));
            label1 = new Label();
            listView2 = new ListView();
            CaseHeader = new ColumnHeader();
            AgeHeader = new ColumnHeader();
            btnRefresh = new Button();
            button2 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 40);
            label1.TabIndex = 0;
            label1.Text = "Status Report";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { CaseHeader, AgeHeader });
            listView2.Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.FullRowSelect = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView2.Location = new Point(12, 51);
            listView2.Margin = new Padding(2);
            listView2.Name = "listView2";
            listView2.Size = new Size(165, 171);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // CaseHeader
            // 
            CaseHeader.Text = "Status";
            CaseHeader.Width = 100;
            // 
            // AgeHeader
            // 
            AgeHeader.Text = "Count";
            AgeHeader.Width = 50;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(215, 51);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 119);
            button2.Name = "button2";
            button2.Size = new Size(89, 35);
            button2.TabIndex = 4;
            button2.Text = "Export";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(215, 187);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(316, 235);
            Controls.Add(btnExit);
            Controls.Add(button2);
            Controls.Add(btnRefresh);
            Controls.Add(listView2);
            Controls.Add(label1);
            Name = "GenerateReport";
            Text = "IT Status Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView2;
        private ColumnHeader CaseHeader;
        private ColumnHeader AgeHeader;
        private Button btnRefresh;
        private Button button2;
        private Button btnExit;
    }
}