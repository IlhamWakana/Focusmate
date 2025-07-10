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

namespace Organresipi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            string connStr = "server=localhost;user=root;password=;database=recipe;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM login WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Dashboard main = new Dashboard();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi gagal: " + ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            DataLogin DataLogin = new DataLogin();
            DataLogin.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
