using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;
using Logic.Entities;

namespace Logic.Readers
{
    public class RssReader : IReader
    {
        public List<FeedItem> ReadFeedItems(Uri uri)
        {
            List<Data.IFeedItem> feedItems = new List<Data.IFeedItem>();
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

            var ret = new List<FeedItem>();
            feedItems.ForEach(x => ret.Add(new FeedItem() { Id = x.Id, Mp3Url = x.Mp3Url, PublishDate = x.PublishDate, Title = x.Title }));
            return ret;
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
            var items = new List<Data.IFeedItem>();
            feedItems.ForEach(x => items.Add(x));
            feed = new Feed(Guid.NewGuid(), syndicationFeed.Title.Text, items, uri, category);

            return feed;
        }

    }
}
