using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Logic.Entities;
using Logic.Readers;

namespace CSharpProject.Views
{
    public partial class MainWindow : Window
    {
        public Feed NewFeedFromForm { get; set; }
        public RssReader RssReader { get; set; }
        public List<Feed> AllFeeds { get; set; }
        public List<Uri> AllUris { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            RssReader = new RssReader();
            AllUris = new List<Uri>
            {
                new Uri("http://alexosigge.libsyn.com/rss"),
                new Uri("http://varvet.libsyn.com/rss"),
                new Uri("http://www.filipandfredrik.com/feed/")
            };
            AllFeeds = new List<Feed>();
           


        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var uri in AllUris)
            {
                AllFeeds.Add(RssReader.ReadFeed(uri));
            }

            foreach (var feed in AllFeeds)
            {
                ListBoxPodcastFeeds.Items.Add(feed);
            }

        }

        private void ListBox_OnSelected(object sender, RoutedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            var selectedFeed = (Feed) ListBoxPodcastFeeds.SelectedItem;
            ListBoxSelectedPodcastEpisodes.Items.Clear();
            foreach (var item in selectedFeed.CollectionFeedItems)
            {
                ListBoxSelectedPodcastEpisodes.Items.Add(item);
            }

        }

        private void buttonAddFeed_Click(object sender, RoutedEventArgs e)
        {
            using (var windowAddFeed = new WindowAddFeed())
            {
                var showDialog = windowAddFeed.ShowDialog();
                if (showDialog != null && showDialog.Value == true)
                {
                    var newFeed = windowAddFeed.FeedOut;
                    MessageBox.Show(newFeed.ToString());
                }
            }



        }
    }
}
