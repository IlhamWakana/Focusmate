namespace Organresipi
{
    partial class mainform
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            resep = new Button();
            rmin = new Button();
            btnMenuPlan = new Button();
            btnShopping = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // resep
            // 
            resep.Location = new Point(30, 80);
            resep.Name = "resep";
            resep.Size = new Size(200, 50);
            resep.TabIndex = 0;
            resep.Text = "Kelola Resep";
            resep.UseVisualStyleBackColor = true;
            resep.Click += button1_Click;
            // 
            // rmin
            // 
            rmin.Location = new Point(270, 80);
            rmin.Name = "rmin";
            rmin.Size = new Size(200, 50);
            rmin.TabIndex = 1;
            rmin.Text = "Inventaris";
            rmin.UseVisualStyleBackColor = true;
            rmin.Click += rmin_Click;
            // 
            // btnMenuPlan
            // 
            btnMenuPlan.Location = new Point(30, 160);
            btnMenuPlan.Name = "btnMenuPlan";
            btnMenuPlan.Size = new Size(200, 50);
            btnMenuPlan.TabIndex = 2;
            btnMenuPlan.Text = "Menu Planning";
            btnMenuPlan.UseVisualStyleBackColor = true;
            btnMenuPlan.Click += BtnMenuPlan_Click;
            // 
            // btnShopping
            // 
            btnShopping.Location = new Point(270, 160);
            btnShopping.Name = "btnShopping";
            btnShopping.Size = new Size(200, 50);
            btnShopping.TabIndex = 3;
            btnShopping.Text = "Belanja Kebutuhan";
            btnShopping.UseVisualStyleBackColor = true;
            btnShopping.Click += BtnShopping_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(600, 310);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(resep);
            panel1.Controls.Add(rmin);
            panel1.Controls.Add(btnMenuPlan);
            panel1.Controls.Add(btnShopping);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(14, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 360);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 26);
            label1.TabIndex = 6;
            label1.Text = "SELAMAT DATANG";
            label1.Click += label1_Click;
            // 
            // mainform
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "mainform";
            Text = "Dashboard";
            Load += mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button resep;
        private System.Windows.Forms.Button rmin;
        private System.Windows.Forms.Button btnMenuPlan;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
