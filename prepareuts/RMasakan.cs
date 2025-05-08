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
    public partial class RMasakan : Form
    {
        public RMasakan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RMasakan_Load(object sender, EventArgs e)
        {
            rar();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO rmasakan (nama_masakan, bahan, deskripsi) VALUES (@nama_masakan, @bahan, @deskripsi)"; // atau tabel member jika beda
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_masakan", textBox1.Text);
                cmd.Parameters.AddWithValue("@bahan", textBox2.Text);
                cmd.Parameters.AddWithValue("@deskripsi", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
                rar();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE rmasakan SET nama_masakan = @nama_masakan, bahan = @bahan, deskripsi = @deskripsi WHERE id = @id;";
                // atau tabel member jika beda
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_masakan", textBox1.Text);
                cmd.Parameters.AddWithValue("@bahan", textBox2.Text);
                cmd.Parameters.AddWithValue("@deskripsi", textBox3.Text);
                cmd.Parameters.AddWithValue("@id", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diguanti");
                rar();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM rmasakan WHERE id=@id"; // atau tabel member jika beda
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihaposh");
                rar();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void rar()
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM rmasakan"; // atau tabel member jika beda
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


    }
}
