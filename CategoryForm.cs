using System;
using System.Windows.Forms;

namespace Orgaresipis
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        // Event handler untuk ketika form dimuat
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // Logika untuk inisialisasi form saat dimuat
            MessageBox.Show("Category Form Loaded");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // Kode untuk menambahkan kategori
            MessageBox.Show("Add Category button clicked");
        }
    }
}
