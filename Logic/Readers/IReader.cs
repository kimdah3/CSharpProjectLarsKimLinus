using System;
using System.Collections.Generic;
using Logic.Entities;

namespace Logic.Readers
{
    public interface IReader
    {
        List<FeedItem> ReadFeedItems(Uri uri);
    }
}