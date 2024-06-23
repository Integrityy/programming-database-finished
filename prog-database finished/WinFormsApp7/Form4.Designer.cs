namespace WinFormsApp7
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label3 = new Label();
            btnLogin = new Button();
            button1 = new Button();
            button2 = new Button();
            btnSignout = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(201, 58);
            label3.Name = "label3";
            label3.Size = new Size(736, 80);
            label3.TabIndex = 6;
            label3.Text = "flame on: arkanoid";
            label3.Click += label3_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkCyan;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Font = new Font("Stencil", 15.75F);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(471, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(182, 68);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Play";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(471, 288);
            button1.Name = "button1";
            button1.Size = new Size(182, 68);
            button1.TabIndex = 11;
            button1.Text = "Settings ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Stencil", 15.75F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(471, 386);
            button2.Name = "button2";
            button2.Size = new Size(182, 68);
            button2.TabIndex = 12;
            button2.Text = "Rankings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSignout
            // 
            btnSignout.BackColor = Color.DarkCyan;
            btnSignout.BackgroundImageLayout = ImageLayout.None;
            btnSignout.FlatAppearance.BorderColor = Color.Black;
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignout.ForeColor = Color.Black;
            btnSignout.Location = new Point(471, 482);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(182, 68);
            btnSignout.TabIndex = 23;
            btnSignout.Text = "sign out";
            btnSignout.UseVisualStyleBackColor = false;
            btnSignout.Click += btnSignout_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 630);
            Controls.Add(btnSignout);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnLogin;
        private Button button1;
        private Button button2;
        private Button btnSignout;
    }
}