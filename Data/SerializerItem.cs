using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{   
    [Serializable]
    public class SerializerItem 
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public List<FeedItems> CollectionFeedItems { get; set; }
        public string Url { get; set; }
        public CategoryItem Category { get; set; }
        

      public  SerializerItem(IFeed Feed)
        {
            this.Id = Feed.Id;
            this.Title = Feed.Title;
            CollectionFeedItems = Feed.CollectionFeedItems.Select(x => new FeedItems(x.Id, x.Title, x.Mp3Url, x.PublishDate)).ToList();
            Url = Feed.Url.ToString();
            Category = new CategoryItem(Feed.Category.Id, Feed.Category.Name);
        }
       
        public SerializerItem()
        {

        }

        public IFeed GetFeed()
        {

            return null;
        }
        
    
    }

    public class CategoryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CategoryItem(Guid Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public CategoryItem()
        {

        }

    }

    public class FeedItems
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Mp3Url { get; set; }
        public DateTime PublishDate { get; set; }
        public FeedItems(Guid Id, string Title, Uri Mp3Url, DateTime PublishDate)
        {
            this.Id = Id;
            this.Title = Title;
            this.Mp3Url = Mp3Url.ToString();
            this.PublishDate = PublishDate;
        }
        public FeedItems()
        {

        }
    }
}
