using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organresipi.Controllers;
using Organresipi.Models;
using Organresipi.MVC.Models;

namespace Organresipi.MVC.Views
{
    public partial class LoginView : Form

    {
        private LoginController loginController;
        public LoginView()
        {
            InitializeComponent();
            loginController = new LoginController();  // Hubungkan ke controller
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Kirim ke controller
            var user = new UserModel { Username = username, Password = password };
            bool success = loginController.Login(user);

            if (success)
            {
                MessageBox.Show("Login berhasil!");
                this.Hide();
                new Dashboard().Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            new DataLogin().Show();
        }
    }
}
