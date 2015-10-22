using System;
using System.Windows.Forms;
using Logic.Entities;
using Logic.Readers;

namespace GUI.Views
{
    public partial class WindowAddPodcastFeed : Form
    {
        public Feed NewFeed { get; set; }

        public WindowAddPodcastFeed()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (NewFeed != null)
            {
                this.DialogResult = DialogResult.OK;
                NewFeed.Category = new Category(textBoxCategory.Text);
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
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



    }
}
