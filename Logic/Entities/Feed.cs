using System;
using System.Collections.Generic;
using Data;

namespace Logic.Entities
{
    public class Feed : IEntity, IFeed
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Data.IFeedItem> CollectionFeedItems { get; set; }
        public Uri Url { get; set; }
        public Data.ICategory Category { get; set; }

        public Feed(Guid id, string title, List<Data.IFeedItem> collectionFeedItems, Uri url, Category category)
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