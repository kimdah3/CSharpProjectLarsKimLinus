using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using System.Web.WebSockets;
using System.Windows.Forms;
using Data;
using GUI.Views;
using GUI2;
using GUI2.Views;
using Logic.Entities;
using Logic.Readers;
using Timer = System.Timers.Timer;

namespace GUI
{
    public partial class MainForm : Form
    {
        public List<Uri> AllUris { get; set; }
        public List<Data.IFeed> AllFeeds { get; set; }
        public List<Category> Categories { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            AllFeeds = new List<Data.IFeed>();
            Categories = new List<Category> { new Category("All"), new Category("Unspecified") };

            var Serializer = new Data.DataSerializer();
            Serializer.LoadFromFile(LoadFeed);

            foreach (var feed in AllFeeds)
            {
                listBoxPodcastFeeds.Items.Add(feed);
                //foreach (var category in Categories)
                //{
                //    if(string.Compare(feed.Category.Name, category.Name) != 0)
                //        Categories.Add((Category)feed.Category); 
                //}

                /*if (string.Compare(feed.Category.Name, "Unspecified") != 0)
                    Categories.Add((Category)feed.Category);*/

                /*******************************************************************************/
                /*************************** Update interval (hours) ***************************/
                /************************************************||*****************************/
                /************************************************\/******************************/
                var timer = new Timer(feed.UpdateInterval * 10000*60*60);
                timer.Start();
                timer.Elapsed += (o, args) => TimerOnElapsed(o, args, feed as Feed);
            }
            UpdateCategoryComboBox();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs, Feed feed)
        {
            var rssReader = new RssReader();
            var newFeedItems = rssReader.ReadFeedItems(feed.Url);

            foreach (var f in AllFeeds)
            {
                if (feed.Equals(f))
                {
                    var i = newFeedItems.Count - f.CollectionFeedItems.Count;
                    f.CollectionFeedItems = new List<IFeedItem>(newFeedItems);
                    MessageBox.Show(i + " new episodes for " + f.Title);
                }
            }

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
                if (addPodcastFeedForm.DialogResult != DialogResult.OK) return;
                AllFeeds.Add(addPodcastFeedForm.NewFeed);
                UpdateFeedList();
            }
        }

        private void UpdateCategoryComboBox()
        {
            comboBoxFeedCategory.Items.Clear();


            foreach (var feed in AllFeeds)
            {
                Categories.Add(feed.Category as Category);
            }

            var distinctItems = Categories.Distinct(new DistinctCategoryComparer());
            Categories = new List<Category>();
            foreach (var item in distinctItems)
            {
                Categories.Add(item);
            }


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
            try
            {
                if (!Validation.ControlSelectionCheck(listBoxPodcastEpisodes.SelectedIndex)) return;

                var feedItem = (FeedItem)listBoxPodcastEpisodes.SelectedItem;
                var feed = listBoxPodcastFeeds.SelectedItem as Feed;
                foreach (var item in feed.CollectionFeedItems.Where(item => item.Equals(feedItem)))
                {
                    item.IsUsed = true;
                }

                Process.Start(feedItem.Mp3Url.AbsoluteUri);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            using (var categorySettingsForm = new CategorySettingsForm(Categories, AllFeeds))
            {
                categorySettingsForm.ShowDialog();

                if (categorySettingsForm.DialogResult != DialogResult.OK) return;
                this.Categories = categorySettingsForm.Categories;
                UpdateCategoryComboBox();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Använder detta för att serialisera. Körs när programmet stängs.
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
                var c = feed.Category as Category;
                if (string.Compare(c.Name, category.Name) == 0)
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
            returFeed.CollectionFeedItems.ForEach(x => feed.addFeedItem(x.Id, x.Title, new Uri(x.Mp3Url), x.PublishDate, x.IsUsed, x.Description));
            feed.setCategory(returFeed.Category.Id, returFeed.Category.Name);
            feed.UpdateInterval = returFeed.UpdateInterval;
        }

        private void buttonDeletePodcastFeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.ControlSelectionCheck(listBoxPodcastFeeds.SelectedIndex)) return;
                var targetFeed = listBoxPodcastFeeds.SelectedItem as Feed;
                AllFeeds.Remove(targetFeed);
                UpdateFeedList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditPodcastFeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.ControlSelectionCheck(listBoxPodcastFeeds.SelectedIndex)) return;

                if (listBoxPodcastFeeds.SelectedIndex == -1) return;
                var targetFeed = listBoxPodcastFeeds.SelectedItem as Feed;
                AllFeeds.Remove(targetFeed);

                using (var editPodcastFeedForm = new EditPodcastFeedForm(targetFeed, Categories))
                {
                    editPodcastFeedForm.ShowDialog();

                    if (editPodcastFeedForm.DialogResult == DialogResult.OK)
                    {
                        AllFeeds.Add(editPodcastFeedForm.EditedFeed);
                    }
                    else
                    {
                        AllFeeds.Add(targetFeed);
                    }
                }
                if (comboBoxFeedCategory.SelectedIndex != -1)
                    UpdateFeedListByCategory(comboBoxFeedCategory.SelectedItem as Category);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShowMore_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.ControlSelectionCheck(listBoxPodcastEpisodes.SelectedIndex)) return;

                var selectedFeedItem = listBoxPodcastEpisodes.SelectedItem as FeedItem;

                using (var showPodcastInfoForm = new ShowPodcastInfoForm(selectedFeedItem))
                {
                    showPodcastInfoForm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
