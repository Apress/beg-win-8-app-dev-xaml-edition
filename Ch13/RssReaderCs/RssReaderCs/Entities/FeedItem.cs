using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReaderCs.Entities
{
    public class FeedItem
    {
        public string Title { get; set; }
        public Uri Link { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Description { get; set; }
    }
}

/*
                 <title>Async articles</title>
        <link>http://blogs.msdn.com/b/ericlippert/archive/2011/10/03/async-articles.aspx</link>
        <pubDate>Mon, 03 Oct 2011 20:30:00 GMT</pubDate>
        <guid isPermaLink="false">91d46819-8472-40ad-a661-2c78acb4018c:10219332</guid>
        <dc:creator>Eric Lippert</dc:creator>
        <slash:comments>0</slash:comments>
        <wfw:commentRss xmlns:wfw="http://wellformedweb.org/CommentAPI/">http://blogs.msdn.com/b/ericlippert/rsscomments.aspx?WeblogPostID=10219332</wfw:commentRss>
        <comments>http://blogs.msdn.com/b/ericlippert/archive/2011/10/03/async-articles.aspx#comments</comments>
        <description>
 */
