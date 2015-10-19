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

namespace GUI2
{
    public partial class Form1 : Form
    {
        public RssReader RssReader { get; set; }
        public List<Uri> AllUris { get; set; }
        public List<Feed> AllFeeds { get; set; }

        public Form1()
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
    }
}
