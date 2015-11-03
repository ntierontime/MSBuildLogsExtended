using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Text;

namespace MSBuildLogsExtended.WcfWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RSSFacade" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RSSFacade.svc or RSSFacade.svc.cs at the Solution Explorer and start debugging.
    public class RssFeeds : MSBuildLogsExtended.WcfWebApp.IRssFeeds
    {

        public Rss20FeedFormatter GetBuild()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetBuild();
            return new Rss20FeedFormatter(feed);
        }


        public Rss20FeedFormatter GetBuildEventCode()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetBuildEventCode();
            return new Rss20FeedFormatter(feed);
        }


        public Rss20FeedFormatter GetBuildLog()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetBuildLog();
            return new Rss20FeedFormatter(feed);
        }


        public Rss20FeedFormatter GetSolution()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetSolution();
            return new Rss20FeedFormatter(feed);
        }


    }
}


