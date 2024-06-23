using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WinFormsApp7
{
    public static class DatabaseHelper
    {
        public static List<string> GetTopScores()
        {
            List<string> topScores = new List<string>();

            string query = "SELECT username, CAST(personal_highscore AS UNSIGNED) as personal_highscore FROM flameondb ORDER BY personal_highscore DESC LIMIT 10";

            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;database=flameon;username=root;password=;"))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader.GetString("username");
                            string score = reader.GetInt64("personal_highscore").ToString();
                            string scoreString = username + ": " + score;
                            topScores.Add(scoreString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the top scores: " + ex.Message);
            }

            return topScores;


        }

    }


}
