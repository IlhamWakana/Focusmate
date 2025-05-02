namespace Orgaresipis
{
    partial class RecipeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            lstRecipes = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(20, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Judul Resep";
            txtTitle.Size = new Size(378, 26);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 50);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Deskripsi";
            txtDescription.Size = new Size(378, 26);
            txtDescription.TabIndex = 1;
            // 
            // lstRecipes
            // 
            lstRecipes.Location = new Point(20, 120);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(654, 137);
            lstRecipes.TabIndex = 2;
            lstRecipes.SelectedIndexChanged += lstRecipes_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(467, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Tambah";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(467, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Ubah";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(467, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Hapus";
            btnDelete.Click += btnDelete_Click;
            // 
            // RecipeForm
            // 
            ClientSize = new Size(686, 300);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(lstRecipes);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "RecipeForm";
            Text = "Kelola Resep";
            Load += RecipeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
