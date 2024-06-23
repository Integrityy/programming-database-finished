namespace WinFormsApp7
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbPassword = new CheckBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignup = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblEnterUsername = new Label();
            lblEnterPassword = new Label();
            lblWrongPW = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(251, 245);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 20.25F);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(251, 316);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(420, 245);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Your Username";
            txtUsername.Size = new Size(316, 35);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(384, 59);
            label3.Name = "label3";
            label3.Size = new Size(352, 80);
            label3.TabIndex = 4;
            label3.Text = "Flame On";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 405);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.BackColor = Color.Transparent;
            cbPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbPassword.ForeColor = Color.White;
            cbPassword.Location = new Point(420, 370);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(132, 23);
            cbPassword.TabIndex = 6;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = false;
            cbPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(420, 316);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Your Password";
            txtPassword.Size = new Size(316, 35);
            txtPassword.TabIndex = 7;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkCyan;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(498, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.DarkCyan;
            btnSignup.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.Black;
            btnSignup.Location = new Point(498, 476);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(146, 48);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkCyan;
            btnExit.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(498, 545);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 48);
            btnExit.TabIndex = 10;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Location = new Point(420, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 5);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Location = new Point(420, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 5);
            panel2.TabIndex = 12;
            // 
            // lblEnterUsername
            // 
            lblEnterUsername.AutoSize = true;
            lblEnterUsername.BackColor = Color.Transparent;
            lblEnterUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterUsername.ForeColor = Color.Red;
            lblEnterUsername.Location = new Point(420, 286);
            lblEnterUsername.Name = "lblEnterUsername";
            lblEnterUsername.Size = new Size(143, 15);
            lblEnterUsername.TabIndex = 24;
            lblEnterUsername.Text = "Please enter a username";
            lblEnterUsername.Visible = false;
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.BackColor = Color.Transparent;
            lblEnterPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterPassword.ForeColor = Color.Red;
            lblEnterPassword.Location = new Point(420, 354);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(140, 15);
            lblEnterPassword.TabIndex = 25;
            lblEnterPassword.Text = "Please enter a password";
            lblEnterPassword.Visible = false;
            // 
            // lblWrongPW
            // 
            lblWrongPW.AutoSize = true;
            lblWrongPW.BackColor = Color.Transparent;
            lblWrongPW.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWrongPW.ForeColor = Color.Red;
            lblWrongPW.Location = new Point(423, 354);
            lblWrongPW.Name = "lblWrongPW";
            lblWrongPW.Size = new Size(204, 15);
            lblWrongPW.TabIndex = 26;
            lblWrongPW.Text = "Wrong Username and/or Password!";
            lblWrongPW.Visible = false;
            lblWrongPW.Click += lblWrongPW_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 630);
            Controls.Add(lblWrongPW);
            Controls.Add(lblEnterPassword);
            Controls.Add(lblEnterUsername);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(cbPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private CheckBox cbPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignup;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Label lblEnterUsername;
        private Label lblEnterPassword;
        private Label lblWrongPW;
    }
}