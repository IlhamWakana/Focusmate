namespace Organresipi
{
    partial class Inventory
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 57);
            dataGridView1.Size = new System.Drawing.Size(776, 241);
            dataGridView1.Name = "dataGridView1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Text = "Data Inventaris";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 320);
            button1.Size = new System.Drawing.Size(100, 30);
            button1.Text = "Kelola Data";
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Load += new System.EventHandler(this.Inventory_Load);
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
