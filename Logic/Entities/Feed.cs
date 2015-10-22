using System;
using System.Collections.Generic;

namespace Logic.Entities
{
    public class Feed : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<FeedItem> CollectionFeedItems { get; set; }
        public Uri Url { get; set; }
        public Category Category { get; set; }

        public Feed(Guid id, string title, List<FeedItem> collectionFeedItems, Uri url, Category category)
        {
            Id = id;
            Title = title;
            CollectionFeedItems = collectionFeedItems;
            Url = url;
            Category = category;
        }


        public override string ToString()
        {
            return $"Title: {Title}";
        }
    }
}