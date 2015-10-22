using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;
using Logic.Entities;

namespace Logic.Readers
{
    public class RssReader : IReader
    {
        public IEnumerable<FeedItem> ReadFeedItems(Uri uri)
        {
            List<FeedItem> feedItems = new List<FeedItem>();
            SyndicationFeed syndicationFeed;
            using (XmlReader xmlReader = XmlReader.Create(uri.AbsoluteUri))
            {
                syndicationFeed = SyndicationFeed.Load(xmlReader);
                xmlReader.Close();
            }

            foreach (var item in syndicationFeed.Items)
            {
                FeedItem feedItem = new FeedItem();
                Guid id = Guid.NewGuid();
                if (Guid.TryParse(item.Id, out id))
                    feedItem.Id = new Guid(item.Id); // Inte alla feeds har korrekt ID därför krävs validering.
                else
                    feedItem.Id = id;
                feedItem.Title = item.Title.Text;
                feedItem.Mp3Url = item.Links[0].Uri;
                feedItem.PublishDate = item.PublishDate.DateTime;

                feedItems.Add(feedItem);
            }

            return feedItems;
        }

        public Feed ReadFeed(Uri uri)
        {
            Feed feed = null;
            var feedItems = new List<FeedItem>();

            SyndicationFeed syndicationFeed;
            using (var xmlReader = XmlReader.Create(uri.AbsoluteUri))
            {
                syndicationFeed = SyndicationFeed.Load(xmlReader);
                xmlReader.Close();
            }

            if (syndicationFeed == null) return null;
            foreach (var item in syndicationFeed.Items)
            {
                FeedItem feedItem = new FeedItem();
                Guid id;

                feedItem.Id = Guid.TryParse(item.Id, out id) ? id : new Guid();

                feedItem.Title = item.Title.Text;
                feedItem.Mp3Url = item.Links[0].Uri;
                feedItem.PublishDate = item.PublishDate.DateTime;
                feedItems.Add(feedItem);
            }

            feed = new Feed(Guid.NewGuid(), syndicationFeed.Title.Text, feedItems, uri);

            return feed;
        }

    }
}
