namespace ITHelpDeskTeamB
{
    partial class CreateUserForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            lblTitle = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            lblUserType = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            cmbUserType = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblUserFirst = new Label();
            lbluserLast = new Label();
            txtUserLast = new TextBox();
            txtUserFirst = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Gill Sans MT", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create New User";
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Gill Sans MT", 10F);
            lblUserName.Location = new Point(30, 170);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(120, 24);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Gill Sans MT", 10F);
            lblPassword.Location = new Point(30, 208);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblUserType
            // 
            lblUserType.BackColor = Color.Transparent;
            lblUserType.Font = new Font("Gill Sans MT", 10F);
            lblUserType.Location = new Point(30, 248);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(120, 24);
            lblUserType.TabIndex = 5;
            lblUserType.Text = "User Type:";
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Gill Sans MT", 10F);
            lblEmail.Location = new Point(30, 298);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 24);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Gill Sans MT", 10F);
            lblPhone.Location = new Point(30, 340);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 24);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Gill Sans MT", 10F);
            txtUserName.Location = new Point(170, 158);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(280, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Gill Sans MT", 10F);
            txtPassword.Location = new Point(170, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(280, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Gill Sans MT", 10F);
            txtEmail.Location = new Point(170, 298);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Gill Sans MT", 10F);
            txtPhone.Location = new Point(170, 337);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 10;
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.Font = new Font("Gill Sans MT", 10F);
            cmbUserType.Items.AddRange(new object[] { "Admin", "IT Support Member", "Project Member", "Report Manager" });
            cmbUserType.Location = new Point(170, 248);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(280, 26);
            cmbUserType.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Gill Sans MT", 10F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(170, 410);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(130, 38);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Create User";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gill Sans MT", 10F);
            btnCancel.Location = new Point(320, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 38);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblUserFirst
            // 
            lblUserFirst.BackColor = Color.Transparent;
            lblUserFirst.Font = new Font("Gill Sans MT", 10F);
            lblUserFirst.Location = new Point(30, 83);
            lblUserFirst.Name = "lblUserFirst";
            lblUserFirst.Size = new Size(120, 24);
            lblUserFirst.TabIndex = 13;
            lblUserFirst.Text = "First Name:";
            // 
            // lbluserLast
            // 
            lbluserLast.BackColor = Color.Transparent;
            lbluserLast.Font = new Font("Gill Sans MT", 10F);
            lbluserLast.Location = new Point(30, 123);
            lbluserLast.Name = "lbluserLast";
            lbluserLast.Size = new Size(120, 24);
            lbluserLast.TabIndex = 14;
            lbluserLast.Text = "Last Name:";
            // 
            // txtUserLast
            // 
            txtUserLast.Font = new Font("Gill Sans MT", 10F);
            txtUserLast.Location = new Point(170, 124);
            txtUserLast.Name = "txtUserLast";
            txtUserLast.Size = new Size(280, 23);
            txtUserLast.TabIndex = 15;
            // 
            // txtUserFirst
            // 
            txtUserFirst.Font = new Font("Gill Sans MT", 10F);
            txtUserFirst.Location = new Point(170, 83);
            txtUserFirst.Name = "txtUserFirst";
            txtUserFirst.Size = new Size(280, 23);
            txtUserFirst.TabIndex = 16;
            // 
            // CreateUserForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(542, 463);
            Controls.Add(txtUserFirst);
            Controls.Add(txtUserLast);
            Controls.Add(lbluserLast);
            Controls.Add(lblUserFirst);
            Controls.Add(lblTitle);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUserType);
            Controls.Add(cmbUserType);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CreateUserForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create New User";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblUserFirst;
        private Label lbluserLast;
        private TextBox txtUserLast;
        private TextBox txtUserFirst;
    }
}