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
    public partial class Kinvent : Form
    {
        private int inventoryId = -1;

        public Kinvent(int id = -1)
        {
            InitializeComponent();
            inventoryId = id;

            if (inventoryId != -1)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            string query = "SELECT * FROM rinventory WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", inventoryId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtNama.Text = reader["nama"].ToString();
                        txtJumlah.Text = reader["jumlah"].ToString();
                        txtKategori.Text = reader["kategori"].ToString();
                    }
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            string query;

            if (inventoryId == -1)
            {
                query = "INSERT INTO rinventory (nama, jumlah, kategori) VALUES (@nama, @jumlah, @kategori)";
            }
            else
            {
                query = "UPDATE rinventory SET nama = @nama, jumlah = @jumlah, kategori = @kategori WHERE id = @id";
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@jumlah", txtJumlah.Text);
                    cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);

                    if (inventoryId != -1)
                    {
                        cmd.Parameters.AddWithValue("@id", inventoryId);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan: " + ex.Message);
                }
            }
        }

        private void Kinvent_Load(object sender, EventArgs e)
        {

        }
    }
}
