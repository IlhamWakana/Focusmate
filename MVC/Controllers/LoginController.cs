using MySql.Data.MySqlClient;
using Organresipi.Models;
using System;
using System.Windows.Forms;

namespace Organresipi.Controllers
{
    public class LoginController
    {
        private string connStr = "server=localhost;user=root;password=;database=recipe;";

        public bool Login(UserModel user)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM login WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader.Read();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi gagal: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
