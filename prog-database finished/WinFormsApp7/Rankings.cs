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
    public partial class Rankings : Form
    {
        private string loggedInUsername;

        public Rankings(List<string> topScores, string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername; // Store the logged-in username
            DisplayTopScores(topScores); // Display the top scores
        }

        private void DisplayTopScores(List<string> topScores)
        {
            Label[] scoreLabels = { lblTop1, lblTop2, lblTop3, lblTop4, lblTop5 };
            Label[] scoreValueLabels = { lblTop1HS, lblTop2HS, lblTop3HS, lblTop4HS, lblTop5HS };

            for (int i = 0; i < scoreLabels.Length; i++)
            {
                if (i < topScores.Count)
                {
                    string[] parts = topScores[i].Split(':');
                    string username = parts[0].Trim();
                    string score = parts[1].Trim();

                    scoreLabels[i].Text = $"{i + 1}. {username}";
                    scoreValueLabels[i].Text = score;

                    if (username == loggedInUsername)
                    {
                        scoreLabels[i].ForeColor = Color.Cyan;
                        scoreValueLabels[i].ForeColor = Color.Cyan;
                    }
                    else
                    {
                        scoreLabels[i].ForeColor = Color.Black;
                        scoreValueLabels[i].ForeColor = Color.Black;
                    }
                }
                else
                {
                    scoreLabels[i].Text = "";
                    scoreValueLabels[i].Text = "";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(loggedInUsername);
            form4.Show();
            this.Hide();
        }

        private void Rankings_Load(object sender, EventArgs e)
        {

        }

    }



}