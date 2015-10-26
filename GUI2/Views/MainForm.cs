using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<Data.IFeed> AllFeeds { get; set; }
        public HashSet<Category> Categories { get; set; }


        public MainForm()
        {
            InitializeComponent();
            RssReader = new RssReader();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            AllFeeds = new List<Data.IFeed>();

            Categories = new HashSet<Category> { new Category("All"), new Category("Unspecified") };

            var Serializer = new Data.DataSerializer();

            Serializer.LoadFromFile(LoadFeed);

            foreach (var feed in AllFeeds)
            {
                listBoxPodcastFeeds.Items.Add(feed);
                if (string.Compare(feed.Category.Name, "Unspecified") != 0)
                    Categories.Add((Category)feed.Category);
            }

            UpdateCategoryComboBox();
        }

        private void listBoxPodcastFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPodcastFeeds.SelectedIndex == -1) return; //Ends method if nothing selected
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
            foreach (var category in Categories)
                comboBoxFeedCategory.Items.Add(category);

        }

        private void UpdateFeedList()
        {
            listBoxPodcastFeeds.Items.Clear();
            foreach (var feed in AllFeeds)
                listBoxPodcastFeeds.Items.Add(feed);
        }

        private void buttonPlayPodcastEpisode_Click(object sender, EventArgs e)
        {
            var feedItem = (FeedItem)listBoxPodcastEpisodes.SelectedItem;
            Process.Start(feedItem.Mp3Url.AbsoluteUri);

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            using (var categorySettingsForm = new CategorySettingsForm(Categories, AllFeeds))
            {
                categorySettingsForm.ShowDialog();

                if (categorySettingsForm.DialogResult == DialogResult.OK)
                {
                    this.Categories = categorySettingsForm.Categories;
                    UpdateCategoryComboBox();
                }

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        { //Använder detta för att testa att serialisera. Körs när programmet stängs.
            Data.DataSerializer test = new Data.DataSerializer();
            test.SaveToFile(AllFeeds);
        }

        private void comboBoxFeedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFeedCategory.SelectedIndex != -1)
            {
                var selectedCategory = comboBoxFeedCategory.SelectedItem as Category;
                if (string.Compare(selectedCategory.Name, "All") == 0) // Om valet är alla kategorier
                    UpdateFeedList();
                else
                {
                    UpdateFeedListByCategory(selectedCategory);
                }
            }
            else
            {
                UpdateFeedList();
            }
        }

        private void UpdateFeedListByCategory(Category category)
        {
            listBoxPodcastFeeds.Items.Clear();

            foreach (var feed in AllFeeds)
            {
                if ((Category)feed.Category == category)
                    listBoxPodcastFeeds.Items.Add(feed);
            }

        }

        public void LoadFeed(Data.SerializerItem returFeed)
        {
            var feed = new Feed();
            AllFeeds.Add(feed);
            feed.Id = returFeed.Id;
            feed.Title = returFeed.Title;
            feed.Url = new Uri(returFeed.Url);
            returFeed.CollectionFeedItems.ForEach(x => feed.addFeedItem(x.Id, x.Title, new Uri(x.Mp3Url), x.PublishDate));
            feed.setCategory(returFeed.Category.Id, returFeed.Category.Name);
        }
    }
}
