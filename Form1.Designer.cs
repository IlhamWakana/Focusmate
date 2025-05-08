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
            this.resep = new System.Windows.Forms.Button();
            this.rmin = new System.Windows.Forms.Button();
            this.btnMenuPlan = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resep
            // 
            this.resep.Location = new System.Drawing.Point(30, 80);
            this.resep.Name = "resep";
            this.resep.Size = new System.Drawing.Size(200, 50);
            this.resep.TabIndex = 0;
            this.resep.Text = "Kelola Resep";
            this.resep.UseVisualStyleBackColor = true;
            this.resep.Click += new System.EventHandler(this.button1_Click);
            // 
            // rmin
            // 
            this.rmin.Location = new System.Drawing.Point(270, 80);
            this.rmin.Name = "rmin";
            this.rmin.Size = new System.Drawing.Size(200, 50);
            this.rmin.TabIndex = 1;
            this.rmin.Text = "Inventaris";
            this.rmin.UseVisualStyleBackColor = true;
            this.rmin.Click += new System.EventHandler(this.rmin_Click);
            // 
            // btnMenuPlan
            // 
            this.btnMenuPlan.Location = new System.Drawing.Point(30, 160);
            this.btnMenuPlan.Name = "btnMenuPlan";
            this.btnMenuPlan.Size = new System.Drawing.Size(200, 50);
            this.btnMenuPlan.TabIndex = 2;
            this.btnMenuPlan.Text = "Menu Planning";
            this.btnMenuPlan.UseVisualStyleBackColor = true;
            this.btnMenuPlan.Click += new System.EventHandler(this.BtnMenuPlan_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.Location = new System.Drawing.Point(270, 160);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(200, 50);
            this.btnShopping.TabIndex = 3;
            this.btnShopping.Text = "Shopping List";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.BtnShopping_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(600, 310);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.resep);
            this.panel1.Controls.Add(this.rmin);
            this.panel1.Controls.Add(this.btnMenuPlan);
            this.panel1.Controls.Add(this.btnShopping);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 360);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELAMAT DATANG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "mainform";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
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
