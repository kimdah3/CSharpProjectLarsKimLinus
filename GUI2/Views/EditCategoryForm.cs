using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Entities;

namespace GUI2.Views
{
    public partial class EditCategoryForm : Form
    {
        public Category NewCategory { get; set; }

        public EditCategoryForm()
        {
            InitializeComponent();
        }

        public EditCategoryForm(Category category)
        {
            InitializeComponent();
            textBoxNewName.Text = category.Name;
            NewCategory = category;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.Cancel;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            NewCategory.Name = textBoxNewName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
