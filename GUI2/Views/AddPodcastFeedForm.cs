using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic.Entities;
using Logic.Readers;

namespace GUI.Views
{
    public partial class AddPodcastFeedForm : Form
    {
        public Feed NewFeed { get; set; }
        private HashSet<Category> _categories;

        public AddPodcastFeedForm()
        {
            InitializeComponent();
        }

        public AddPodcastFeedForm(HashSet<Category> categories)
        {
            InitializeComponent();
            _categories = categories;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private Category GetSelectedCategory()
        {
            if (comboBoxCategories.SelectedIndex == -1)
            {
                return null;
            }
            return comboBoxCategories.SelectedItem as Category;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (NewFeed != null)
            {
                NewFeed.Category = GetSelectedCategory();
                if (NewFeed.Category != null)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("SAda");
                }
            }
            else
            {
                DialogResult = DialogResult.Abort;
                MessageBox.Show("No new podcast added.");
            }

        }

        private void textBoxURL_Leave(object sender, EventArgs e)
        {
            var rssReader = new RssReader();
            try
            {
                NewFeed = rssReader.ReadFeed(new Uri(textBoxURL.Text));
                labelTitleShow.Text = NewFeed.Title + ", episodes: " + NewFeed.CollectionFeedItems.Count;
            }
            catch (UriFormatException ex)
            {
                labelTitleShow.Text = ex.Message;
                NewFeed = null;
            }
            catch (Exception ex)
            {
                labelTitleShow.Text = ex.Message;
                NewFeed = null;
            }
        }

        private void AddPodcastFeedForm_Load(object sender, EventArgs e)
        {
            foreach (var category in _categories)
            {
                comboBoxCategories.Items.Add(category);
            }
        }
    }
}
