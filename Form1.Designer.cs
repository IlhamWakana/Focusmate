namespace Orgaresipis
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpenRecipeForm;
        private System.Windows.Forms.Button btnOpenCategoryForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOpenRecipeForm = new System.Windows.Forms.Button();
            this.btnOpenCategoryForm = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnOpenRecipeForm
            this.btnOpenRecipeForm.Location = new System.Drawing.Point(50, 40);
            this.btnOpenRecipeForm.Name = "btnOpenRecipeForm";
            this.btnOpenRecipeForm.Size = new System.Drawing.Size(150, 40);
            this.btnOpenRecipeForm.TabIndex = 0;
            this.btnOpenRecipeForm.Text = "Kelola Resep";
            this.btnOpenRecipeForm.UseVisualStyleBackColor = true;
            this.btnOpenRecipeForm.Click += new System.EventHandler(this.btnOpenRecipeForm_Click);

            // btnOpenCategoryForm
            this.btnOpenCategoryForm.Location = new System.Drawing.Point(50, 100);
            this.btnOpenCategoryForm.Name = "btnOpenCategoryForm";
            this.btnOpenCategoryForm.Size = new System.Drawing.Size(150, 40);
            this.btnOpenCategoryForm.TabIndex = 1;
            this.btnOpenCategoryForm.Text = "Kelola Kategori";
            this.btnOpenCategoryForm.UseVisualStyleBackColor = true;
            this.btnOpenCategoryForm.Click += new System.EventHandler(this.btnOpenCategoryForm_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.btnOpenRecipeForm);
            this.Controls.Add(this.btnOpenCategoryForm);
            this.Name = "Form1";
            this.Text = "Orgaresipis - Menu Utama";
            this.ResumeLayout(false);
        }
    }
}
