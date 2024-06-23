namespace WinFormsApp7
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btnSignup = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            lblTaken = new Label();
            lblPW = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblRegistrationComplete = new Label();
            lblRegistrationFailed = new Label();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.DarkCyan;
            btnSignup.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.Black;
            btnSignup.Location = new Point(555, 511);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(146, 48);
            btnSignup.TabIndex = 18;
            btnSignup.Text = "↩";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkCyan;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(555, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 48);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Sign Up";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(477, 295);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Your Password";
            txtPassword.Size = new Size(316, 35);
            txtPassword.TabIndex = 16;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 394);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(405, 69);
            label3.Name = "label3";
            label3.Size = new Size(361, 80);
            label3.TabIndex = 13;
            label3.Text = "register";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(477, 224);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Your Username";
            txtUsername.Size = new Size(316, 35);
            txtUsername.TabIndex = 12;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 20.25F);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(216, 295);
            label2.Name = "label2";
            label2.Size = new Size(255, 32);
            label2.TabIndex = 11;
            label2.Text = "Enter Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(216, 224);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 10;
            label1.Text = "Enter Username:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Location = new Point(477, 367);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Enter Your Password";
            txtConfirmPassword.Size = new Size(316, 35);
            txtConfirmPassword.TabIndex = 20;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 20.25F);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(186, 367);
            label5.Name = "label5";
            label5.Size = new Size(287, 32);
            label5.TabIndex = 19;
            label5.Text = "Confirm Password:";
            // 
            // lblTaken
            // 
            lblTaken.AutoSize = true;
            lblTaken.BackColor = Color.Transparent;
            lblTaken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaken.ForeColor = Color.Red;
            lblTaken.Location = new Point(477, 262);
            lblTaken.Name = "lblTaken";
            lblTaken.Size = new Size(142, 15);
            lblTaken.TabIndex = 23;
            lblTaken.Text = "Username already taken";
            lblTaken.Visible = false;
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.BackColor = Color.Transparent;
            lblPW.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPW.ForeColor = Color.Red;
            lblPW.Location = new Point(477, 409);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(134, 15);
            lblPW.TabIndex = 24;
            lblPW.Text = "Passwords don't match";
            lblPW.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Location = new Point(477, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 5);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Location = new Point(477, 325);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 5);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Location = new Point(477, 397);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 5);
            panel3.TabIndex = 27;
            // 
            // lblRegistrationComplete
            // 
            lblRegistrationComplete.AutoSize = true;
            lblRegistrationComplete.BackColor = Color.Transparent;
            lblRegistrationComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrationComplete.ForeColor = Color.LawnGreen;
            lblRegistrationComplete.Location = new Point(477, 409);
            lblRegistrationComplete.Name = "lblRegistrationComplete";
            lblRegistrationComplete.Size = new Size(143, 15);
            lblRegistrationComplete.TabIndex = 28;
            lblRegistrationComplete.Text = "Registration Completed!";
            lblRegistrationComplete.Visible = false;
            // 
            // lblRegistrationFailed
            // 
            lblRegistrationFailed.AutoSize = true;
            lblRegistrationFailed.BackColor = Color.Transparent;
            lblRegistrationFailed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrationFailed.ForeColor = Color.Red;
            lblRegistrationFailed.Location = new Point(477, 409);
            lblRegistrationFailed.Name = "lblRegistrationFailed";
            lblRegistrationFailed.Size = new Size(114, 15);
            lblRegistrationFailed.TabIndex = 29;
            lblRegistrationFailed.Text = "Registration Failed!";
            lblRegistrationFailed.Visible = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 630);
            Controls.Add(lblRegistrationFailed);
            Controls.Add(lblRegistrationComplete);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblPW);
            Controls.Add(lblTaken);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label5);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignup;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label4;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label5;
        private Label lblTaken;
        private Label lblPW;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblRegistrationComplete;
        private Label lblRegistrationFailed;
    }
}