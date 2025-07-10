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
    public partial class KMasakan : Form
    {
        public KMasakan()
        {
            InitializeComponent();
        }

        private void KMasakan_Load(object sender, EventArgs e)
        {
            LoadMasakanData();
        }

        private void LoadMasakanData()
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM masakan"; // ambil data dari tabel masakan
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO masakan (nama_masakan) VALUES (@nama_masakan)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_masakan", textBoxNamaMasakan.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Masakan berhasil ditambahkan");
                LoadMasakanData();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE masakan SET nama_masakan = @nama_masakan WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_masakan", textBoxNamaMasakan.Text);
                cmd.Parameters.AddWithValue("@id", textBoxIdMasakan.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Masakan berhasil diperbarui");
                LoadMasakanData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM masakan WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textBoxIdMasakan.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Masakan berhasil dihapus");
                LoadMasakanData();
            }
        }
    }
}

