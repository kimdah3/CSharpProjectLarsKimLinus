using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public interface IFeed
    {
        Guid Id { get; set; }
        string Title { get; set; }
        List<IFeedItem> CollectionFeedItems { get; set; }
        Uri Url { get; set; }
        ICategory Category { get; set; }
    }
}
