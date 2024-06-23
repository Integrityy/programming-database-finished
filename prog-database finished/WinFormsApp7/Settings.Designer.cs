namespace WinFormsApp7
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            label3 = new Label();
            btnBack = new Button();
            lblPasswordChange = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            lblTaken = new Label();
            txtConfirmNewPW = new TextBox();
            label5 = new Label();
            txtNewPW = new TextBox();
            label4 = new Label();
            txtNewUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            lblUsernameChange = new Label();
            btnDelete = new Button();
            lblWarning = new Label();
            btnYes = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(271, 37);
            label3.Name = "label3";
            label3.Size = new Size(607, 80);
            label3.TabIndex = 5;
            label3.Text = "update account";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkCyan;
            btnBack.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(52, 37);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 52);
            btnBack.TabIndex = 22;
            btnBack.Text = "↩";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPasswordChange
            // 
            lblPasswordChange.AutoSize = true;
            lblPasswordChange.BackColor = Color.Transparent;
            lblPasswordChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordChange.ForeColor = Color.LawnGreen;
            lblPasswordChange.Location = new Point(539, 341);
            lblPasswordChange.Name = "lblPasswordChange";
            lblPasswordChange.Size = new Size(109, 15);
            lblPasswordChange.TabIndex = 43;
            lblPasswordChange.Text = "Update Complete!";
            lblPasswordChange.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Location = new Point(539, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 5);
            panel3.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Location = new Point(541, 273);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 5);
            panel2.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Location = new Point(541, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 5);
            panel1.TabIndex = 40;
            // 
            // lblTaken
            // 
            lblTaken.AutoSize = true;
            lblTaken.BackColor = Color.Transparent;
            lblTaken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaken.ForeColor = Color.Red;
            lblTaken.Location = new Point(539, 221);
            lblTaken.Name = "lblTaken";
            lblTaken.Size = new Size(145, 15);
            lblTaken.TabIndex = 38;
            lblTaken.Text = "Username already taken.";
            lblTaken.Visible = false;
            lblTaken.Click += lblTaken_Click;
            // 
            // txtConfirmNewPW
            // 
            txtConfirmNewPW.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmNewPW.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPW.ForeColor = Color.Black;
            txtConfirmNewPW.Location = new Point(541, 296);
            txtConfirmNewPW.Multiline = true;
            txtConfirmNewPW.Name = "txtConfirmNewPW";
            txtConfirmNewPW.PasswordChar = '*';
            txtConfirmNewPW.PlaceholderText = "Confirm New Password";
            txtConfirmNewPW.Size = new Size(316, 35);
            txtConfirmNewPW.TabIndex = 37;
            txtConfirmNewPW.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 20.25F);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(185, 299);
            label5.Name = "label5";
            label5.Size = new Size(350, 32);
            label5.TabIndex = 36;
            label5.Text = "Confirm New Password:";
            // 
            // txtNewPW
            // 
            txtNewPW.BorderStyle = BorderStyle.FixedSingle;
            txtNewPW.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPW.ForeColor = Color.Black;
            txtNewPW.Location = new Point(541, 243);
            txtNewPW.Multiline = true;
            txtNewPW.Name = "txtNewPW";
            txtNewPW.PasswordChar = '*';
            txtNewPW.PlaceholderText = "Enter New Password";
            txtNewPW.Size = new Size(316, 35);
            txtNewPW.TabIndex = 34;
            txtNewPW.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 326);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 33;
            // 
            // txtNewUsername
            // 
            txtNewUsername.BorderStyle = BorderStyle.FixedSingle;
            txtNewUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUsername.ForeColor = Color.Black;
            txtNewUsername.Location = new Point(541, 183);
            txtNewUsername.Multiline = true;
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.PlaceholderText = "Enter Username";
            txtNewUsername.Size = new Size(316, 35);
            txtNewUsername.TabIndex = 32;
            txtNewUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 20.25F);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(217, 243);
            label2.Name = "label2";
            label2.Size = new Size(318, 32);
            label2.TabIndex = 31;
            label2.Text = "Enter New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(217, 183);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 30;
            label1.Text = "Enter New Username:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.Font = new Font("Stencil", 15.75F);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(625, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 48);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblUsernameChange
            // 
            lblUsernameChange.AutoSize = true;
            lblUsernameChange.BackColor = Color.Transparent;
            lblUsernameChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameChange.ForeColor = Color.LawnGreen;
            lblUsernameChange.Location = new Point(541, 221);
            lblUsernameChange.Name = "lblUsernameChange";
            lblUsernameChange.Size = new Size(109, 15);
            lblUsernameChange.TabIndex = 49;
            lblUsernameChange.Text = "Update Complete!";
            lblUsernameChange.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Font = new Font("Stencil", 15.75F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(625, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 48);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.BackColor = Color.Transparent;
            lblWarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(481, 410);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(433, 15);
            lblWarning.TabIndex = 51;
            lblWarning.Text = "Are you sure you want to delete your account? This action cannot be undone.";
            lblWarning.Visible = false;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.DarkCyan;
            btnYes.BackgroundImageLayout = ImageLayout.None;
            btnYes.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.Black;
            btnYes.Location = new Point(625, 428);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(76, 48);
            btnYes.TabIndex = 52;
            btnYes.Text = "confirm";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Visible = false;
            btnYes.Click += btnYes_Click_1;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.DarkCyan;
            btnNo.BackgroundImageLayout = ImageLayout.None;
            btnNo.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.Black;
            btnNo.Location = new Point(711, 428);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(76, 48);
            btnNo.TabIndex = 53;
            btnNo.Text = "cancel";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Visible = false;
            btnNo.Click += btnNo_Click_1;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 630);
            Controls.Add(lblTaken);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblWarning);
            Controls.Add(btnDelete);
            Controls.Add(lblUsernameChange);
            Controls.Add(btnUpdate);
            Controls.Add(lblPasswordChange);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtConfirmNewPW);
            Controls.Add(label5);
            Controls.Add(txtNewPW);
            Controls.Add(label4);
            Controls.Add(txtNewUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnBack;
        private Label lblPasswordChange;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label lblPW;
        private Label lblTaken;
        private TextBox txtConfirmNewPW;
        private Label label5;
        private TextBox txtNewPW;
        private Label label4;
        private TextBox txtNewUsername;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private Label lblUsernameChange;
        private Button btnDelete;
        private Label lblWarning;
        private Button btnYes;
        private Button btnNo;
    }
}