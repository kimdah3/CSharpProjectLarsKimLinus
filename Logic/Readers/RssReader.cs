using System;
using System.Collections.Generic;
using System.Globalization;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;
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
            Category category = null;

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
                feedItem.Mp3Url = item.Links[1].Uri;
                feedItem.PublishDate = item.PublishDate.DateTime;
                feedItems.Add(feedItem);
            }

            // Hämtar category som finns innästlat i ett attribut.
            foreach (var elementExtension in syndicationFeed.ElementExtensions)
            {
                if (elementExtension.OuterName.Equals("category"))
                {
                    category = new Category(elementExtension.GetObject<XElement>().FirstAttribute.Value);
                }

            }

            //var categories = syndicationFeed.ElementExtensions.

            feed = new Feed(Guid.NewGuid(), syndicationFeed.Title.Text, feedItems, uri, category);

            return feed;
        }

    }
}
