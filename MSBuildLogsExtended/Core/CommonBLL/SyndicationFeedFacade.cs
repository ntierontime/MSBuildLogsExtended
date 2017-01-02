using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace MSBuildLogsExtended.CommonBLL
{
    public static class SyndicationFeedFacade 
    {

        public static SyndicationFeed GetBuild()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "Build", "WPCommonOfBuild");

            SyndicationFeed feed = new SyndicationFeed(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Rss_Title_of_Build, MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Rss_Description_of_Build, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.));

            MSBuildLogsExtended.CommonBLL.BuildService instance = new MSBuildLogsExtended.CommonBLL.BuildService();

            var request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.HomeOwner, "Build", "WPEntityRelatedOfBuild", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


        public static SyndicationFeed GetBuildEventCode()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "BuildEventCode", "WPCommonOfBuildEventCode");

            SyndicationFeed feed = new SyndicationFeed(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Rss_Title_of_BuildEventCode, MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Rss_Description_of_BuildEventCode, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.));

            MSBuildLogsExtended.CommonBLL.BuildEventCodeService instance = new MSBuildLogsExtended.CommonBLL.BuildEventCodeService();

            var request = new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.HomeOwner, "BuildEventCode", "WPEntityRelatedOfBuildEventCode", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


        public static SyndicationFeed GetBuildLog()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "BuildLog", "WPCommonOfBuildLog");

            SyndicationFeed feed = new SyndicationFeed(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Rss_Title_of_BuildLog, MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Rss_Description_of_BuildLog, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.));

            MSBuildLogsExtended.CommonBLL.BuildLogService instance = new MSBuildLogsExtended.CommonBLL.BuildLogService();

            var request = new MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.HomeOwner, "BuildLog", "WPEntityRelatedOfBuildLog", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


        public static SyndicationFeed GetSolution()
        {
            string urlOfList = string.Format("{0}{1}/{2}", Framework.Web.WebFormApplicationApplicationVariables.WebAppRootUrl, "Solution", "WPCommonOfSolution");

            SyndicationFeed feed = new SyndicationFeed(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Rss_Title_of_Solution, MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Rss_Description_of_Solution, new Uri(urlOfList));
            //feed.Authors.Add(new SyndicationPerson(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.));
            //feed.Categories.Add(new SyndicationCategory(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.));

            MSBuildLogsExtended.CommonBLL.SolutionService instance = new MSBuildLogsExtended.CommonBLL.SolutionService();

            var request = new MSBuildLogsExtended.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll();
            request.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            request.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection("LastModifiedDateTime:DESC");
            var fromDataSource = instance.GetCollectionOfRssItemOfAll(request);

            List<SyndicationItem> items = new List<SyndicationItem>();
            if (fromDataSource.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                foreach (var datasourceItem in fromDataSource.Message)
                {
		            //string urlOfEntityRelated = string.Format("{0}{1}/{2}?{3}", MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.HomeOwner, "Solution", "WPEntityRelatedOfSolution", "{Query String Parameters}");
                    SyndicationItem item1 = new SyndicationItem(
                        datasourceItem.Title, 
                        datasourceItem.Description, 
                        new Uri(urlOfList), // should be urlOfEntityRelated, should enter query string parameters
                        datasourceItem.IdentifierInString, 
                        datasourceItem.PubDate);

                    items.Add(item1);
                }
            }

            feed.Items = items;
            return feed;
        }


    }
}

