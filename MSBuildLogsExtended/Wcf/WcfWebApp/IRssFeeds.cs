using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;

namespace MSBuildLogsExtended.WcfWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRSSFacade" in both code and config file together.
    [ServiceContract]
    public interface IRssFeeds
    {

        [OperationContract]
        [WebGet]
        Rss20FeedFormatter GetBuild();



        [OperationContract]
        [WebGet]
        Rss20FeedFormatter GetBuildEventCode();



        [OperationContract]
        [WebGet]
        Rss20FeedFormatter GetBuildLog();



        [OperationContract]
        [WebGet]
        Rss20FeedFormatter GetSolution();



    }
}


