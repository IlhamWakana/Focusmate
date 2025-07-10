using System;
using System.Windows.Forms;

namespace Organresipi
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RMasakan rm = new RMasakan();
            rm.Show();
        }

        private void rmin_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }

        private void BtnMenuPlan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Planning diklik");
        }

        private void BtnShopping_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shopping List diklik");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
