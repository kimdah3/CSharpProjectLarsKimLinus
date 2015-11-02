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
using Logic.Readers;

namespace GUI2.Views
{
    public partial class EditPodcastFeedForm : Form
    {
        public Feed OriginalFeed { get; set; }
        public Feed EditedFeed { get; set; }
        public List<Category> Categories { get; set; }
        public EditPodcastFeedForm()
        {
            InitializeComponent();
        }

        public EditPodcastFeedForm(Feed originalFeed, List<Category> categories)
        {
            InitializeComponent();
            OriginalFeed = originalFeed;
            Categories = categories;
        }

        private void EditPodcastFeedForm_Load(object sender, EventArgs e)
        {
            textBoxURL.Text = OriginalFeed.Url.AbsoluteUri;
            textBoxTitle.Text = OriginalFeed.Title;
            textBoxUpdateInterval.Text = OriginalFeed.UpdateInterval + "";
            labelEpisode.Text = "Episodes: " + OriginalFeed.CollectionFeedItems.Count + "";

            foreach (var c in Categories)
            {
                comboBoxCategories.Items.Add(c);

                if (string.Compare(c.Name,OriginalFeed.Category.Name) == 0)
                {
                    comboBoxCategories.SelectedItem = c;
                }
            }



        }

        private void textBoxURL_Leave(object sender, EventArgs e)
        {
            var rssReader = new RssReader();
            try
            {
                EditedFeed = rssReader.ReadFeed(new Uri(textBoxURL.Text));
                textBoxTitle.Text = EditedFeed.Title;
                labelEpisode.Text = "Episodes: " + EditedFeed.CollectionFeedItems.Count + "";
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show("Can't read URL: " + textBoxURL.Text + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't read URL: " + textBoxURL.Text + " " + ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.TextboxNotEmpty(textBoxTitle.Text);
                Validation.NumberCheck(textBoxUpdateInterval.Text);
                Validation.UrlCheck(textBoxURL.Text);
                Validation.ComboboxCheck(comboBoxCategories.SelectedItem.ToString());
                EditedFeed.Title = textBoxTitle.Text;
                EditedFeed.Url = new Uri(textBoxURL.Text);
                EditedFeed.UpdateInterval = Convert.ToInt32(textBoxUpdateInterval.Text);
                if (comboBoxCategories.SelectedIndex > -1)
                {
                    EditedFeed.Category = comboBoxCategories.SelectedItem as Category;
                }
                else
                {
                    MessageBox.Show("Must select a category");
                    return;
                }


                DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


        }
    }
}
