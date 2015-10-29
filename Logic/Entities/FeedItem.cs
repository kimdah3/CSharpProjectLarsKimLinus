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
        public bool IsUsed { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            if (IsUsed)
                return Title + " " + "  LISTENED TOO.";
            else
                return Title + " ";
        }
    }
}