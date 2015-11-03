using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Text;

namespace MSBuildLogsExtended.WcfWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Atom10Feeds" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Atom10Feeds.svc or Atom10Feeds.svc.cs at the Solution Explorer and start debugging.
    public class Atom10Feeds : MSBuildLogsExtended.WcfWebApp.IAtom10Feeds
    {

        public Atom10FeedFormatter GetBuild()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetBuild();
            return new Atom10FeedFormatter(feed);
        }


        public Atom10FeedFormatter GetBuildEventCode()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetBuildEventCode();
            return new Atom10FeedFormatter(feed);
        }


        public Atom10FeedFormatter GetBuildLog()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetBuildLog();
            return new Atom10FeedFormatter(feed);
        }


        public Atom10FeedFormatter GetSolution()
        {
            SyndicationFeed feed = MSBuildLogsExtended.CommonBLL.SyndicationFeedFacade.GetSolution();
            return new Atom10FeedFormatter(feed);
        }


    }
}


