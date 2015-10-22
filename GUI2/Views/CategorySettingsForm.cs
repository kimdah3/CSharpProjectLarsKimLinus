using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using Logic.Entities;

namespace GUI2.Views
{
    public partial class CategorySettingsForm : Form
    {
        public HashSet<Category> Categories { get; set; }

        public CategorySettingsForm()
        {
            InitializeComponent();
        }

        public CategorySettingsForm(HashSet<Category> categories)
        {
            InitializeComponent();
            this.Categories = categories;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void CategorySettingsForm_Load(object sender, EventArgs e)
        {
            foreach (var category in Categories)
            {
                listBoxCategories.Items.Add(category);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
