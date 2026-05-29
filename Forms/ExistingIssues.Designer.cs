namespace ITHelpDeskTeamB.Forms
{
    partial class ExistingIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingIssues));
            dataGridView1 = new DataGridView();
            lblExistingIssues = new Label();
            btnRefresh = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(353, 273);
            dataGridView1.TabIndex = 0;
            // 
            // lblExistingIssues
            // 
            lblExistingIssues.AutoSize = true;
            lblExistingIssues.BackColor = Color.Transparent;
            lblExistingIssues.Font = new Font("Gill Sans MT", 21.75F);
            lblExistingIssues.Location = new Point(37, 52);
            lblExistingIssues.Name = "lblExistingIssues";
            lblExistingIssues.Size = new Size(235, 52);
            lblExistingIssues.TabIndex = 1;
            lblExistingIssues.Text = "Existing Issues";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(90, 169);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 43);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(90, 274);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 43);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // ExistingIssues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(716, 421);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(lblExistingIssues);
            Controls.Add(dataGridView1);
            Name = "ExistingIssues";
            Text = "ExistingIssues";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblExistingIssues;
        private Button btnRefresh;
        private Button btnExit;
    }
}