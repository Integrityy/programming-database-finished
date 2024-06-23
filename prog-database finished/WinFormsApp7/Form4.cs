using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form4 : Form
    {
        private string loggedInUsername;

        public Form4(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Arkanoid Play = new Arkanoid(loggedInUsername);
            Play.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(loggedInUsername);
            settings.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> topScores = DatabaseHelper.GetTopScores();
            Rankings rankings = new Rankings(topScores, loggedInUsername);
            rankings.Show();
            this.Hide();

        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Form2.LoggedInUsername = null;
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

