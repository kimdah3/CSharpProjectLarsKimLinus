using System;
using System.Runtime;

namespace Logic.Entities
{
    public class FeedItem : Data.IFeedItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Uri Mp3Url { get; set; }
        public DateTime PublishDate { get; set; }


        public override string ToString()
        {
            return Title + " " + PublishDate.ToShortDateString();
        }
    }
}