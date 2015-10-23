using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public interface IFeedItem
    {
        Guid Id { get; set; }
        string Title { get; set; }
        Uri Mp3Url { get; set; }
        DateTime PublishDate { get; set; }
    }
}
