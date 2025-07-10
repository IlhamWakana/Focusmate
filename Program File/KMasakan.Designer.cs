namespace Organresipi
{
    partial class KMasakan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxNamaMasakan = new System.Windows.Forms.TextBox();
            this.textBoxIdMasakan = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // textBoxNamaMasakan
            this.textBoxNamaMasakan.Location = new System.Drawing.Point(30, 30);
            this.textBoxNamaMasakan.Name = "textBoxNamaMasakan";
            this.textBoxNamaMasakan.Size = new System.Drawing.Size(200, 26);
            this.textBoxNamaMasakan.TabIndex = 0;

            // textBoxIdMasakan
            this.textBoxIdMasakan.Location = new System.Drawing.Point(30, 70);
            this.textBoxIdMasakan.Name = "textBoxIdMasakan";
            this.textBoxIdMasakan.Size = new System.Drawing.Size(100, 26);
            this.textBoxIdMasakan.TabIndex = 1;

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(30, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // buttonUpdate
            this.buttonUpdate.Location = new System.Drawing.Point(120, 110);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);

            // buttonDelete
            this.buttonDelete.Location = new System.Drawing.Point(210, 110);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 200);
            this.dataGridView1.TabIndex = 5;

            // KMasakan
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxIdMasakan);
            this.Controls.Add(this.textBoxNamaMasakan);
            this.Name = "KMasakan";
            this.Text = "CRUD Masakan";
            this.Load += new System.EventHandler(this.KMasakan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxNamaMasakan;
        private System.Windows.Forms.TextBox textBoxIdMasakan;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
