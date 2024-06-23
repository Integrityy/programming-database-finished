using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp7
{
    public partial class Register : Form
    {
        private MySqlConnection connection;

        public Register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=flameon;username=root;password=;");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblRegistrationFailed.Visible = true;
                lblTaken.Visible = false;
                lblPW.Visible = false;
                lblRegistrationComplete.Visible = false;
                return;
            }

            if (password != confirmPassword)
            {
                lblPW.Text = "Passwords don't match.";
                lblPW.Visible = true;
                return;
            }

            try
            {
                connection.Open();

                string checkUserQuery = "SELECT COUNT(*) FROM flameondb WHERE username = @username";
                MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                checkUserCommand.Parameters.AddWithValue("@username", username);

                int userExists = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                if (userExists > 0)
                {
                    lblTaken.Text = "Username is already taken.";
                    lblTaken.Visible = true;
                    return;
                }

                string registerQuery = "INSERT INTO flameondb (username, password) VALUES (@username, @password)";
                MySqlCommand command = new MySqlCommand(registerQuery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    lblRegistrationComplete.Visible = true;
                    lblTaken.Visible = false;
                    lblPW.Visible = false;
                    lblRegistrationFailed.Visible = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUsername.Clear();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form2 back = new Form2();
            back.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }
    }
}
