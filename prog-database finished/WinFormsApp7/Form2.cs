using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection;
        public static string? LoggedInUsername { get; set; }

        public Form2()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=flameon;username=root;password=;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                lblEnterUsername.Visible = true;
                lblEnterPassword.Visible = false;

                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblEnterUsername.Visible = false;
                lblEnterPassword.Visible = true;
                return;

            }

            try
            {
                connection.Open();
                string loginQuery = "SELECT COUNT(*) FROM flameondb WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(loginQuery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    LoggedInUsername = username;
                    Form4 admin = new Form4(LoggedInUsername);

                    admin.Show();
                    this.Hide();
                }
                else
                {
                    lblWrongPW.Visible = true;
                    lblEnterPassword.Visible = false;
                    lblEnterUsername.Visible = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWrongPW_Click(object sender, EventArgs e)
        {

        }
    }
}
