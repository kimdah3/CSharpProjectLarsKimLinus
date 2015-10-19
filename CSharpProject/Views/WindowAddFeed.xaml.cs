using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Logic.Entities;
using Logic.Readers;

namespace CSharpProject.Views
{
    /// <summary>
    /// Interaction logic for WindowAddFeed.xaml
    /// </summary>
    public partial class WindowAddFeed : Window, IDisposable
    {

        public Feed FeedOut { get; set; }

        public WindowAddFeed()
        {
            FeedOut = null;
            InitializeComponent();
        }

        private void textBoxUrl_LostFocus(object sender, RoutedEventArgs e)
        {
            var rssReader = new RssReader();
            try
            {
                FeedOut = rssReader.ReadFeed(new Uri(textBoxUrl.Text));
                labelTitleShow.Content = FeedOut.Title + ", episodes: " + FeedOut.CollectionFeedItems.Count;
            }
            catch (UriFormatException ex)
            {
                labelTitleShow.Content = ex.Message;
                FeedOut = null;
            }
            catch (Exception ex)
            {
                labelTitleShow.Content = ex.Message;
                FeedOut = null;
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (FeedOut != null)
                this.DialogResult = true;
            else
                MessageBox.Show("No FeedOut found!");
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Dispose()
        {
        }
    }
}
