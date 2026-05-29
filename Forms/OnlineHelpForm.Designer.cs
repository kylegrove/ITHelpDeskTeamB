using System.Diagnostics;

namespace ITHelpDeskTeamB
{
	partial class OnlineHelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineHelpForm));
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Location = new Point(60, 33);
            label2.Name = "label2";
            label2.Size = new Size(430, 203);
            label2.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(161, 101);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(214, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "50 Common IT Problems and Solutions";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Gill Sans MT", 16F, FontStyle.Bold);
            label3.Location = new Point(131, 53);
            label3.Name = "label3";
            label3.Size = new Size(283, 31);
            label3.TabIndex = 13;
            label3.Text = "Online Support Resources";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(190, 129);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(169, 15);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Troubleshooting Methodology";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(155, 155);
            linkLabel3.Margin = new Padding(2, 0, 2, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(229, 15);
            linkLabel3.TabIndex = 15;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Steps to Troubleshoot Almost Any IT Issue";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(138, 185);
            linkLabel4.Margin = new Padding(2, 0, 2, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(266, 15);
            linkLabel4.TabIndex = 16;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "10 Most Common Hardware Issues and Solutions";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(415, 249);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 33);
            btnReturn.TabIndex = 17;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // OnlineHelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 284);
            Controls.Add(btnReturn);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2, 2, 2, 2);
            Name = "OnlineHelpForm";
            Text = "Online Help";
            ResumeLayout(false);
            PerformLayout();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://itadon.com/blog/50-most-common-it-support-problems-and-their-solutions/",
				UseShellExecute = true
			});
		}


		#endregion

		private Label label2;
		private LinkLabel linkLabel1;
		private Label label3;
		private LinkLabel linkLabel2;
		private LinkLabel linkLabel3;
		private LinkLabel linkLabel4;
        private Button btnReturn;
    }
}