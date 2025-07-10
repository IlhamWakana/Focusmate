using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organresipi
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            Inventaris inventaris = new Inventaris();
            inventaris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BelanjaHariancs belanjaHarian = new BelanjaHariancs();
            belanjaHarian.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
