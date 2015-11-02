using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Data;
using GUI;
using Logic.Entities;

namespace GUI2.Views
{
    public partial class CategorySettingsForm : Form
    {
        public HashSet<Category> Categories { get; set; }
        public List<IFeed> AllFeeds { get; set; }

        public bool IsCategoriesChanged { get; set; }

        public CategorySettingsForm()
        {
            InitializeComponent();
        }

        public CategorySettingsForm(HashSet<Category> categories, List<IFeed> allFeeds)
        {
            InitializeComponent();
            this.Categories = categories;
            this.AllFeeds = allFeeds;
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

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.TextboxNotEmpty(textBoxCategoryName.Text)) return;

                var newCategory = new Category(textBoxCategoryName.Text);

                foreach (var category in Categories.Where(category => string.Compare(category.Name, newCategory.Name) == 0))
                {
                    newCategory = category;
                }

                Categories.Add(newCategory);
                UpdateCategoriesListBox();
                IsCategoriesChanged = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            try
            {
                if (!Validation.ControlSelectionCheck(listBoxCategories.SelectedIndex)) return;
                if (listBoxCategories.SelectedIndex == -1) return;

                var category = listBoxCategories.SelectedItem as Category;
                var unspecifiedCategory = new Category("Unspecified");
                Categories.Remove(category);

                foreach (var feed in AllFeeds)
                {
                    var c = feed.Category as Category;
                    if (string.Compare(c.Name, category.Name) == 0)
                        feed.Category = unspecifiedCategory;
                }


                foreach (var c in Categories) // Ser till att en category inte ändras till samma namns som en befintlig.
                    if (string.Compare(unspecifiedCategory.Name, c.Name) == 0)
                        unspecifiedCategory = c;

                Categories.Add(unspecifiedCategory);
                UpdateCategoriesListBox();
                IsCategoriesChanged = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.ControlSelectionCheck(listBoxCategories.SelectedIndex)) return;
                if (listBoxCategories.SelectedIndex == -1) return;
                var category = (Category)listBoxCategories.SelectedItem;

                Categories.Remove(category);

                foreach (var feed in AllFeeds)
                {
                    var c = feed.Category as Category;
                    if (string.Compare(c.Name, category.Name) == 0)
                        feed.Category = null;
                }

                using (var editCategoryForm = new EditCategoryForm(category))
                {
                    editCategoryForm.ShowDialog();

                    if (editCategoryForm.DialogResult == DialogResult.OK)
                    {
                        category = editCategoryForm.NewCategory;

                        foreach (var c in Categories) // Ser till att en category inte ändras till samma namns som en befintlig.
                            if (string.Compare(category.Name, c.Name) == 0)
                                category = c;
                        Categories.Add(category);
                    }
                    else
                    {
                        Categories.Add(category);
                    }
                }

                foreach (var feed in AllFeeds)
                {
                    var c = feed.Category as Category;
                    if (c == null)
                        feed.Category = category;
                }


                UpdateCategoriesListBox();
                IsCategoriesChanged = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
