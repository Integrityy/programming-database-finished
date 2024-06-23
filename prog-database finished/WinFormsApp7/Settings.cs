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
using MySql.Data.MySqlClient;


namespace WinFormsApp7
{
    public partial class Settings : Form
    {
        private MySqlConnection connection;
        private string loggedInUsername;

        public Settings(string loggedInUsername)
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=flameon;username=root;password=;");
            this.loggedInUsername = loggedInUsername;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(loggedInUsername);
            form4.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text.Trim();
            string newPassword = txtNewPW.Text.Trim();
            string confirmNewPassword = txtConfirmNewPW.Text.Trim();


            if (!string.IsNullOrEmpty(newPassword) && newPassword != confirmNewPassword)
            {
                lblTaken.Text = "Passwords do not match.";
                lblTaken.Visible = true;
                return;
            }

            try
            {
                connection.Open();

                if (!string.IsNullOrEmpty(newUsername))
                {
                    MySqlCommand checkUsernameCmd = new MySqlCommand("SELECT COUNT(*) FROM flameondb WHERE username = @newUsername", connection);
                    checkUsernameCmd.Parameters.AddWithValue("@newUsername", newUsername);

                    int count = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        lblTaken.Visible = true;
                        lblUsernameChange.Visible = false;
                        lblPasswordChange.Visible = false;

                    }
                    else
                    {
                        MySqlCommand updateUsernameCmd = new MySqlCommand("UPDATE flameondb SET username = @newUsername WHERE username = @loggedInUsername", connection);
                        updateUsernameCmd.Parameters.AddWithValue("@newUsername", newUsername);
                        updateUsernameCmd.Parameters.AddWithValue("@loggedInUsername", loggedInUsername);

                        updateUsernameCmd.ExecuteNonQuery();

                        lblTaken.Visible = false;
                        lblUsernameChange.Visible = true;
                        lblPasswordChange.Visible = false;
                        loggedInUsername = newUsername;
                    }
                }

                if (!string.IsNullOrEmpty(newPassword))
                {
                    MySqlCommand updatePasswordCmd = new MySqlCommand("UPDATE flameondb SET password = @newPassword WHERE username = @loggedInUsername", connection);
                    updatePasswordCmd.Parameters.AddWithValue("@newPassword", newPassword);
                    updatePasswordCmd.Parameters.AddWithValue("@loggedInUsername", loggedInUsername);

                    updatePasswordCmd.ExecuteNonQuery();

                    lblTaken.Visible = false;
                    lblUsernameChange.Visible = false;
                    lblPasswordChange.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            btnDelete.Visible = true;
            lblTaken.Visible = false;
            lblUsernameChange.Visible = false;
            lblPasswordChange.Visible = false;

        }

        private void lblTaken_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                MySqlCommand deleteCmd = new MySqlCommand("DELETE FROM flameondb WHERE username = @loggedInUsername", connection);
                deleteCmd.Parameters.AddWithValue("@loggedInUsername", loggedInUsername);

                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Account deleted successfully.");

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "Are you sure you want to delete your account? This action cannot be undone.";
            lblWarning.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;
            btnDelete.Visible = false;
            lblTaken.Visible = false;
            lblUsernameChange.Visible = false;
            lblPasswordChange.Visible = false;
        }
    }
}
