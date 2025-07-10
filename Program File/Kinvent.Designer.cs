namespace Organresipi
{
    partial class Kinvent
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox txtNama, txtJumlah, txtKategori;
        private System.Windows.Forms.Button btnSimpan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            txtJumlah = new TextBox();
            txtKategori = new TextBox();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nama Bahan";
            // 
            // label2
            // 
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Jumlah";
            // 
            // label3
            // 
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Kategori";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(140, 20);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(289, 26);
            txtNama.TabIndex = 1;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(140, 60);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(289, 26);
            txtJumlah.TabIndex = 3;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(140, 100);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(289, 26);
            txtKategori.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(140, 140);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Kinvent
            // 
            ClientSize = new Size(662, 278);
            Controls.Add(label1);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(txtJumlah);
            Controls.Add(label3);
            Controls.Add(txtKategori);
            Controls.Add(btnSimpan);
            Name = "Kinvent";
            Text = "Kelola Inventaris";
            Load += Kinvent_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
