using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinFormsApp7
{
    public partial class Arkanoid : Form
    {
        private MySqlConnection connection;
        private string loggedInUsername;


        int fire1;
        int fire2;
        int speed;
        int score;
        int level;
        int targetsRemaining;

        bool right;
        bool left;
        bool gameover;
        bool paused;

        Random random = new Random();

        PictureBox[] Array = new PictureBox[0];

        public Arkanoid(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            this.DoubleBuffered = true;
            connection = new MySqlConnection("server=localhost;database=flameon;username=root;password=;");
            timer.Interval = 20;
            Placetargets();
            gamesetup();
        }

        private void gamesetup()
        {
            gameover = false;
            paused = false;
            fire1 = 5;
            fire2 = 5;
            speed = 50;
            score = 0;
            level = 1;
            targetsRemaining = Array.Length;
            lbScore.Text = "Score: " + score;

            flame.Left = 381;
            flame.Top = 494;

            platform.Left = 351;
            platform.Top = 520;

            timer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag as string == "targets")
                {
                }
            }
        }

        private void Gameover(string finalscore)
        {
            gameover = true;
            timer.Stop();
            lbScore.Text = "Score: " + score + " " + finalscore;

            int currentHighScore = GetPersonalHighScore(loggedInUsername);

            if (score > currentHighScore)
            {
                SaveHighscore(loggedInUsername, score);
            }

            lblGameOver.Visible = true;
            lblTryAgain.Visible = true;
            btnExit.Visible = true;

            level = 1;
            RespawnTargets();

            flame.Left = 381;
            flame.Top = 494;

            platform.Left = 351;
            platform.Top = 520;
        }

        private void Placetargets()
        {
            Removetargets();

            int formationIndex = (level - 1) % 5;

            switch (formationIndex)
            {
                case 0:
                    RectangleFormation();
                    break;
                case 1:
                    SquareFormation();
                    break;
                case 2:
                    TriangleFormation();
                    break;
                case 3:
                    ZigzagFormation();
                    break;
                case 4:
                    CircleFormation();
                    break;
                default:
                    RectangleFormation();
                    break;
            }

            targetsRemaining = Array.Length;
        }


        private void ZigzagFormation()
        {
            int rows = 5;
            int cols = 10;
            int targetWidth = 40;
            int targetHeight = 20;
            int spacing = 30;
            int startY = 50;
            int startX = (this.ClientSize.Width - (cols * (targetWidth + spacing))) / 2;

            Array = new PictureBox[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                bool moveRight = (i % 2 == 0);
                int x = moveRight ? startX : startX + cols * (targetWidth + spacing) - targetWidth;
                int y = startY + i * (targetHeight + spacing);

                for (int j = 0; j < cols; j++)
                {
                    Array[index] = new PictureBox();
                    Array[index].Height = targetHeight;
                    Array[index].Width = targetWidth;
                    Array[index].Tag = "targets";
                    Array[index].BackColor = Color.SkyBlue;

                    Array[index].Left = x;
                    Array[index].Top = y;

                    this.Controls.Add(Array[index]);

                    x += moveRight ? (targetWidth + spacing) : -(targetWidth + spacing);
                    index++;
                }
            }

            targetsRemaining = Array.Length;
        }




        private void RectangleFormation()
        {
            int rows = 3;
            int cols = 5;
            int targetWidth = 100;
            int targetHeight = 32;
            int spacing = 30;

            Array = new PictureBox[rows * cols];
            int top = 50;
            int left = (this.ClientSize.Width - (cols * (targetWidth + spacing))) / 2;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int index = i * cols + j;
                    Array[index] = new PictureBox();
                    Array[index].Height = targetHeight;
                    Array[index].Width = targetWidth;
                    Array[index].Tag = "targets";
                    Array[index].BackColor = Color.Red;

                    ControlPaint.DrawBorder(Array[index].CreateGraphics(), Array[index].ClientRectangle,
                                             Color.Black, ButtonBorderStyle.Solid);

                    Array[index].Padding = new Padding(1);

                    Array[index].Left = left + j * (targetWidth + spacing);
                    Array[index].Top = top + i * (targetHeight + spacing);
                    this.Controls.Add(Array[index]);
                }
            }
        }

        private void TriangleFormation()
        {
            int levels = 5;
            int targetWidth = 80;
            int targetHeight = 32;
            int spacing = 30;

            int totalTargets = levels * (levels + 1) / 2;
            Array = new PictureBox[totalTargets];
            int index = 0;
            int top = 50;

            for (int i = 0; i < levels; i++)
            {
                int cols = i + 1;
                int left = (this.ClientSize.Width - (cols * (targetWidth + spacing))) / 2;

                for (int j = 0; j < cols; j++)
                {
                    Array[index] = new PictureBox();
                    Array[index].Height = targetHeight;
                    Array[index].Width = targetWidth;
                    Array[index].Tag = "targets";
                    Array[index].BackColor = Color.Green;

                    Array[index].Left = left + j * (targetWidth + spacing);
                    Array[index].Top = top + i * (targetHeight + spacing);
                    this.Controls.Add(Array[index]);
                    index++;
                }
            }
        }

        private void CircleFormation()
        {
            int targets = 12;
            int radius = 150;
            int targetWidth = 50;
            int targetHeight = 50;

            Array = new PictureBox[targets + 6];
            Point center = new Point(this.ClientSize.Width / 2, 200);

            for (int i = 0; i < targets; i++)
            {
                double angle = i * (2 * Math.PI / targets);
                int x = (int)(center.X + radius * Math.Cos(angle));
                int y = (int)(center.Y + radius * Math.Sin(angle));

                Array[i] = new PictureBox();
                Array[i].Height = targetHeight;
                Array[i].Width = targetWidth;
                Array[i].Tag = "targets";
                Array[i].BackColor = Color.Orange;

                Array[i].Left = x - targetWidth / 2;
                Array[i].Top = y - targetHeight / 2;
                this.Controls.Add(Array[i]);
            }

            int innerRadius = 100;
            int innerTargets = 6;
            for (int i = 0; i < innerTargets; i++)
            {
                double angle = i * (2 * Math.PI / innerTargets);
                int x = (int)(center.X + innerRadius * Math.Cos(angle));
                int y = (int)(center.Y + innerRadius * Math.Sin(angle));

                Array[targets + i] = new PictureBox();
                Array[targets + i].Height = targetHeight;
                Array[targets + i].Width = targetWidth;
                Array[targets + i].Tag = "targets";
                Array[targets + i].BackColor = Color.Orange;

                Array[targets + i].Left = x - targetWidth / 2;
                Array[targets + i].Top = y - targetHeight / 2;
                this.Controls.Add(Array[targets + i]);
            }
        }


        private void SquareFormation()
        {
            int rows = 5;
            int cols = 5;
            int targetWidth = 60;
            int targetHeight = 32;
            int spacing = 30;

            Array = new PictureBox[rows * cols];
            int top = 50;
            int left = (this.ClientSize.Width - (cols * (targetWidth + spacing))) / 2;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int index = i * cols + j;
                    Array[index] = new PictureBox();
                    Array[index].Height = targetHeight;
                    Array[index].Width = targetWidth;
                    Array[index].Tag = "targets";
                    Array[index].BackColor = Color.Yellow;

                    Array[index].Left = left + j * (targetWidth + spacing);
                    Array[index].Top = top + i * (targetHeight + spacing);
                    this.Controls.Add(Array[index]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                int index = i * cols + (cols - 1) / 2;
                Array[index].BackColor = Color.Yellow;
            }
            for (int j = 0; j < cols; j++)
            {
                int index = (rows - 1) / 2 * cols + j;
                Array[index].BackColor = Color.Yellow;
            }
        }

        private void Removetargets()
        {
            foreach (PictureBox x in Array)
            {
                this.Controls.Remove(x);
            }
        }

        private void RespawnTargets()
        {
            Removetargets();
            Placetargets();
            targetsRemaining = Array.Length;

            flame.Left = 381;
            flame.Top = 494;

            platform.Left = 351;
            platform.Top = 520;


        }

        private void GameTimer(object sender, EventArgs e)
        {
            if (paused)
            {
                return;
            }

            lbScore.Text = "Score: " + score;

            if (left && platform.Left > 0)
            {
                platform.Left -= speed;
            }
            if (right && platform.Left < 686)
            {
                platform.Left += speed;
            }

            flame.Left += fire1;
            flame.Top += fire2;

            if (flame.Left < 0 || flame.Left > 772)
            {
                fire1 = -fire1;
            }
            if (flame.Top < 0)
            {
                fire2 = -fire2;
            }

            if (flame.Bounds.IntersectsWith(platform.Bounds))
            {
                fire2 = -Math.Abs(fire2);

                if (fire1 < 0)
                {
                    fire1 = -Math.Abs(fire1);
                }
                else
                {
                    fire1 = Math.Abs(fire1);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag as string == "targets")
                {
                    if (flame.Bounds.IntersectsWith(x.Bounds))
                    {
                        score++;
                        targetsRemaining--;

                        fire2 = -fire2;

                        this.Controls.Remove(x);
                    }
                }
            }

            if (targetsRemaining == 0)
            {
                level++;
                fire1 = (fire1 < 0) ? fire1 - 1 : fire1 + 1;
                fire2 = (fire2 < 0) ? fire2 - 1 : fire2 + 1;

                if (level <= 5)
                {
                    RespawnTargets();
                }
                else
                {
                    level = 1;
                    RespawnTargets();
                }
            }

            if (flame.Top > 672)
            {
                Gameover(" ");
            }
        }


        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (paused)
                {
                    paused = false;
                    lblPause.Visible = false;
                    lblResume.Visible = false;
                    btnExit.Visible = false;
                    lblGameOver.Visible = false;
                    lblTryAgain.Visible = false;
                    timer.Start();
                }
                else
                {
                    paused = true;
                    lblPause.Visible = true;
                    lblResume.Visible = true;
                    btnExit.Visible = true;
                    timer.Stop();
                }
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Enter && gameover)
            {
                lblGameOver.Visible = false;
                lblTryAgain.Visible = false;
                btnExit.Visible = false;
                Removetargets();
                Placetargets();
                gamesetup();
            }
        }

        private void Arkanoid_Load(object sender, EventArgs e)
        {

        }

        private void platform_Click(object sender, EventArgs e)
        {

        }

        private void SaveHighscore(string username, int personal_highscore)
        {
            string query = "UPDATE flameondb SET personal_highscore = @personal_highscore WHERE username = @username";

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", loggedInUsername);
                    cmd.Parameters.AddWithValue("@personal_highscore", personal_highscore);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the high score: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private int GetPersonalHighScore(string username)
        {
            int personalHighScore = 0;
            string query = "SELECT personal_highscore FROM flameondb WHERE username = @username";

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        personalHighScore = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the personal high score: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return personalHighScore;
        }

        private void lblTryAgain_Click(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void lbPause_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4(loggedInUsername);
            form4.Show();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {

        }
    }
}