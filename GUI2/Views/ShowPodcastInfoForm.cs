using System;
using System.Windows.Forms;
using Logic.Entities;

namespace GUI2.Views
{
    public partial class ShowPodcastInfoForm : Form
    {
        public FeedItem FeedItem { get; set; }

        public ShowPodcastInfoForm()
        {
            InitializeComponent();
        }

        public ShowPodcastInfoForm(FeedItem feedItem)
        {
            InitializeComponent();
            FeedItem = feedItem;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ShowPodcastInfoForm_Load(object sender, EventArgs e)
        {
            textBoxTitle.Text = FeedItem.Title;
            textBoxDescription.Text = (string.IsNullOrWhiteSpace(FeedItem.Description)) ? "No description found." : FeedItem.Description;
            textBoxMp3Url.Text = FeedItem.Mp3Url.AbsoluteUri;
            textBoxPublishDate.Text = FeedItem.PublishDate.ToLongDateString();
        }
    }
}
