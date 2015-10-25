﻿using System;
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

        public Feed()
        {
            CollectionFeedItems = new List<IFeedItem>();
        }


        public override string ToString()
        {
            return $"Title: {Title}";
        }

        public void addFeedItem(Guid ID, string title, Uri Mp3Url, DateTime PublishDate)
        {

            var Item = new FeedItem();

            Item.Id = Id; Item.Title = title; Item.Mp3Url = Mp3Url; Item.PublishDate = PublishDate;
            CollectionFeedItems.Add(Item);
        }

        public void setCategory(Guid Id, string Title)
        {
            if (Category != null)
            {
                Category.Id = Id;
                Category.Name = Title;
            }
            else
            {
                Category = new Category(Title);
                Category.Id = Id;
            }
        }
    }
}