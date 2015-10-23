using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GUI.Views;
using GUI2.Views;
using Logic.Entities;
using Logic.Readers;

namespace GUI
{
    public partial class MainForm : Form
    {
        public RssReader RssReader { get; set; }
        public List<Uri> AllUris { get; set; }
        public List<Feed> AllFeeds { get; set; }
        public HashSet<Category> Categories { get; set; }

        public MainForm()
        {
            InitializeComponent();
            RssReader = new RssReader();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            AllFeeds = new List<Feed>();
            Categories = new HashSet<Category> { new Category("Unspecified")};

            AllUris = new List<Uri>
            {
                new Uri("http://alexosigge.libsyn.com/rss"),
                //new Uri("http://varvet.libsyn.com/rss"),
                //new Uri("http://www.filipandfredrik.com/feed/"),
                new Uri("http://www.radiohoudi.se/feed/podcast/")
            };


            foreach (var uri in AllUris)
            {
                AllFeeds.Add(RssReader.ReadFeed(uri));
            }

            foreach (var feed in AllFeeds)
            {
                listBoxPodcastFeeds.Items.Add(feed);
            }

            UpdateCategoryComboBox();
        }

        private void listBoxPodcastFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var feed = (Feed)listBoxPodcastFeeds.SelectedItem;
            listBoxPodcastEpisodes.Items.Clear();
            foreach (var item in feed.CollectionFeedItems)
            {
                listBoxPodcastEpisodes.Items.Add(item);
            }
        }

        private void buttonAddPodcastFeed_Click(object sender, EventArgs e)
        {
            using (var addPodcastFeedForm = new AddPodcastFeedForm(Categories))
            {
                addPodcastFeedForm.ShowDialog();
                if (addPodcastFeedForm.DialogResult == DialogResult.OK)
                {
                    AllFeeds.Add(addPodcastFeedForm.NewFeed);
                    UpdateFeedList();
                }
            }
        }

        private void UpdateCategoryComboBox()
        {
            comboBoxFeedCategory.Items.Clear();

            /*foreach (var feed in AllFeeds)
            {
                categories.Add(feed.Category.Name);
            }*/

            foreach(var category in Categories)
                comboBoxFeedCategory.Items.Add(category);

        }

        private void UpdateFeedList()
        {
            listBoxPodcastFeeds.Items.Clear();
            foreach (var feed in AllFeeds)
            {
                listBoxPodcastFeeds.Items.Add(feed);
            }
        }

        private void buttonPlayPodcastEpisode_Click(object sender, EventArgs e)
        {
            var feedItem = (FeedItem)listBoxPodcastEpisodes.SelectedItem;
            Process.Start(feedItem.Mp3Url.AbsoluteUri);

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            using (var categorySettingsForm = new CategorySettingsForm(Categories))
            {
                categorySettingsForm.ShowDialog();

                if (categorySettingsForm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        { //Använder detta för att testa att serialisera. Körs när programmet stängs.
            Data.DataSerializer test = new Data.DataSerializer();
            test.SaveToFile(AllFeeds[0]);
        }
    }
}
