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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            string connStr = "server=localhost;user id=root;password=;database=recipe;";
            string query = "SELECT * FROM rinventory";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kinvent kelola = new Kinvent();
            kelola.ShowDialog();
            LoadInventoryData(); // refresh setelah kembali
        }
    }
}
