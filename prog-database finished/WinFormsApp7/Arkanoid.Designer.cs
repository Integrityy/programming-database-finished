namespace WinFormsApp7
{
    partial class Arkanoid
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid));
            lbScore = new Label();
            platform = new PictureBox();
            flame = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            lblGameOver = new Label();
            lblTryAgain = new Label();
            btnExit = new Button();
            lblPause = new Label();
            lblResume = new Label();
            ((System.ComponentModel.ISupportInitialize)platform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flame).BeginInit();
            SuspendLayout();
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.BackColor = Color.Transparent;
            lbScore.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbScore.ForeColor = Color.Cyan;
            lbScore.Location = new Point(21, 24);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(98, 22);
            lbScore.TabIndex = 0;
            lbScore.Text = "Score: 0";
            // 
            // platform
            // 
            platform.BackColor = Color.Black;
            platform.BackgroundImage = (Image)resources.GetObject("platform.BackgroundImage");
            platform.BackgroundImageLayout = ImageLayout.Stretch;
            platform.Location = new Point(342, 522);
            platform.Name = "platform";
            platform.Size = new Size(100, 16);
            platform.TabIndex = 1;
            platform.TabStop = false;
            platform.Click += platform_Click;
            // 
            // flame
            // 
            flame.BackColor = Color.OrangeRed;
            flame.BackgroundImage = (Image)resources.GetObject("flame.BackgroundImage");
            flame.BackgroundImageLayout = ImageLayout.Stretch;
            flame.Location = new Point(385, 403);
            flame.Name = "flame";
            flame.Size = new Size(25, 23);
            flame.TabIndex = 2;
            flame.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += GameTimer;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.FlatStyle = FlatStyle.Flat;
            lblGameOver.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = Color.Cyan;
            lblGameOver.Location = new Point(204, 133);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(411, 76);
            lblGameOver.TabIndex = 4;
            lblGameOver.Text = "Game over!";
            lblGameOver.Visible = false;
            lblGameOver.Click += lblGameOver_Click;
            // 
            // lblTryAgain
            // 
            lblTryAgain.AutoSize = true;
            lblTryAgain.BackColor = Color.Transparent;
            lblTryAgain.FlatStyle = FlatStyle.Flat;
            lblTryAgain.Font = new Font("Stencil", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTryAgain.ForeColor = Color.Cyan;
            lblTryAgain.Location = new Point(237, 209);
            lblTryAgain.Name = "lblTryAgain";
            lblTryAgain.Size = new Size(326, 24);
            lblTryAgain.TabIndex = 5;
            lblTryAgain.Text = "Press 'Enter' to play again.";
            lblTryAgain.Visible = false;
            lblTryAgain.Click += lblTryAgain_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkCyan;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(330, 264);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 48);
            btnExit.TabIndex = 10;
            btnExit.Text = "menu";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblPause
            // 
            lblPause.AutoSize = true;
            lblPause.BackColor = Color.Transparent;
            lblPause.FlatStyle = FlatStyle.Flat;
            lblPause.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPause.ForeColor = Color.Cyan;
            lblPause.Location = new Point(168, 122);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(467, 76);
            lblPause.TabIndex = 11;
            lblPause.Text = "game paused";
            lblPause.Visible = false;
            // 
            // lblResume
            // 
            lblResume.AutoSize = true;
            lblResume.BackColor = Color.Transparent;
            lblResume.FlatStyle = FlatStyle.Flat;
            lblResume.Font = new Font("Stencil", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResume.ForeColor = Color.Cyan;
            lblResume.Location = new Point(265, 209);
            lblResume.Name = "lblResume";
            lblResume.Size = new Size(261, 24);
            lblResume.TabIndex = 12;
            lblResume.Text = "Press 'Esc' to resume.";
            lblResume.Visible = false;
            // 
            // Arkanoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 536);
            Controls.Add(lblResume);
            Controls.Add(lblPause);
            Controls.Add(btnExit);
            Controls.Add(lblTryAgain);
            Controls.Add(lblGameOver);
            Controls.Add(flame);
            Controls.Add(platform);
            Controls.Add(lbScore);
            Name = "Arkanoid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arkanoid";
            Load += Arkanoid_Load;
            KeyDown += Keyisdown;
            KeyUp += Keyisup;
            ((System.ComponentModel.ISupportInitialize)platform).EndInit();
            ((System.ComponentModel.ISupportInitialize)flame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbScore;
        private PictureBox platform;
        private PictureBox flame;
        private System.Windows.Forms.Timer timer;
        private Label lblGameOver;
        private Label lblTryAgain;
        private Button btnExit;
        private Label lblPause;
        private Label lblResume;
    }
}