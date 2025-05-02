using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Orgaresipis
{
    public partial class RecipeForm : Form
    {
        private List<Recipe> recipes = new List<Recipe>();

        public RecipeForm()
        {
            InitializeComponent();
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            // Kosongkan List saat awal
            lstRecipes.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Recipe r = new Recipe
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text
            };
            recipes.Add(r);
            RefreshList();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedIndex >= 0)
            {
                recipes[lstRecipes.SelectedIndex].Title = txtTitle.Text;
                recipes[lstRecipes.SelectedIndex].Description = txtDescription.Text;
                RefreshList();
                ClearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedIndex >= 0)
            {
                recipes.RemoveAt(lstRecipes.SelectedIndex);
                RefreshList();
                ClearInputs();
            }
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedIndex >= 0)
            {
                var selected = recipes[lstRecipes.SelectedIndex];
                txtTitle.Text = selected.Title;
                txtDescription.Text = selected.Description;
            }
        }

        private void RefreshList()
        {
            lstRecipes.DataSource = null;
            lstRecipes.DataSource = recipes;
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
        }
    }
}
