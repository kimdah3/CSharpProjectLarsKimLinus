using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GUI.Views;
using Logic.Entities;
using Logic.Readers;

namespace GUI
{
    public partial class MainForm : Form
    {
        public RssReader RssReader { get; set; }
        public List<Uri> AllUris { get; set; }
        public List<Feed> AllFeeds { get; set; }

        public MainForm()
        {
            InitializeComponent();
            RssReader = new RssReader();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            AllUris = new List<Uri>
            {
                new Uri("http://alexosigge.libsyn.com/rss"),
                new Uri("http://alexosigge.libsyn.com/rss"),
                new Uri("http://alexosigge.libsyn.com/rss"),
                //new Uri("http://varvet.libsyn.com/rss"),
                //new Uri("http://www.filipandfredrik.com/feed/"),
                new Uri("http://www.radiohoudi.se/feed/podcast/")
            };

            AllFeeds = new List<Feed>();

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
            using (var windowAddPodcastFeed = new WindowAddPodcastFeed())
            {
                windowAddPodcastFeed.ShowDialog();
                if (windowAddPodcastFeed.DialogResult == DialogResult.OK)
                {
                    AllFeeds.Add(windowAddPodcastFeed.NewFeed);
                    UpdateFeedList();
                }
            }
        }

        private void UpdateCategoryComboBox()
        {
            HashSet<string> categories = new HashSet<string>();
            comboBoxFeedCategory.Items.Clear();

            foreach (var feed in AllFeeds)
            {
                categories.Add(feed.Category.Name);
            }

            foreach(var category in categories)
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
    }
}
