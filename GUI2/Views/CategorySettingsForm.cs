using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GUI;
using Logic.Entities;

namespace GUI2.Views
{
    public partial class CategorySettingsForm : Form
    {
        public HashSet<Category> Categories { get; set; }
        public bool IsCategoriesChanged { get; set; }

        public CategorySettingsForm()
        {
            InitializeComponent();
        }

        public CategorySettingsForm(HashSet<Category> categories)
        {
            InitializeComponent();
            this.Categories = categories;
            IsCategoriesChanged = false;
        }


        private void CategorySettingsForm_Load(object sender, EventArgs e)
        {
            UpdateCategoriesListBox();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = IsCategoriesChanged ? DialogResult.OK : DialogResult.Ignore;
        }

        //Skall ändras till smidigare lösning med lambda och 
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var newCategory = new Category(textBoxCategoryName.Text);

            foreach (var category in Categories.Where(category => category == newCategory))
            {
                newCategory = category;
            }

            Categories.Add(newCategory);
            UpdateCategoriesListBox();
            IsCategoriesChanged = true;
        }

        private void UpdateCategoriesListBox()
        {
            listBoxCategories.Items.Clear();
            foreach (var category in Categories)
            {
                listBoxCategories.Items.Add(category);
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex == -1) return;

            var category = (Category)listBoxCategories.SelectedItem;
            Categories.Remove(category);
            UpdateCategoriesListBox();
            IsCategoriesChanged = true;

        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex == -1) return;
            var category = (Category)listBoxCategories.SelectedItem;

            Categories.Remove(category);

            using (var editCategoryForm = new EditCategoryForm(category))
            {
                editCategoryForm.ShowDialog();

                if (editCategoryForm.DialogResult == DialogResult.OK)
                {
                    category = editCategoryForm.NewCategory;

                    foreach (var c in Categories) // Ser till att en category inte ändras till samma namns som en befintlig.
                        if (category == c)
                            category = c;
                    Categories.Add(category);
                }
                else
                {
                    Categories.Add(category);
                }
            }
            UpdateCategoriesListBox();
            IsCategoriesChanged = true;
        }
    }
}
