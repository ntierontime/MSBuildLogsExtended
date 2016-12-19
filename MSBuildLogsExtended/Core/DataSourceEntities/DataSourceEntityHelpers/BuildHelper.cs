using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// provides some common methods/actions/stubs. 
    /// </summary>
    public static partial class BuildHelper
    {
		#region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build CreateEntity(
			System.Int64 id
			,System.Int32 solutionId
			,System.String name
			,System.String description
			,System.DateTime buildStartTime
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Build _retval = new MSBuildLogsExtended.DataSourceEntities.Build(
				id
				,solutionId
				,name
				,description
				,buildStartTime
				);
            return _retval;
        }

		#endregion CreateEntity(...)

		#region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildLogsExtended.DataSourceEntities.Build item)
        {
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.BuildStartTime < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.BuildStartTime = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}

        }


        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void ValidateValueBeforeSaveToDatabase(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildLogsExtended.DataSourceEntities.Build _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

		#endregion ValidateValueBeforeSaveToDatabase(...)

		#region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void AssignEnityReferenceIDs(MSBuildLogsExtended.DataSourceEntities.BuildCollection input, System.Int32 solutionId)
		{
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildLogsExtended.DataSourceEntities.Build _Item = input[i];
				_Item.SolutionId = solutionId;
            }
		}

		#endregion AssignEnityReferenceIDs(...)


		#region CreateNameValuePair(...)

        /// <summary>
        /// Creates a new instance of view NameValuePair.
        /// </summary>
        /// <returns>an instance of <see cref="Framework.NameValuePair"/></returns>
        public static Framework.NameValuePair CreateNameValuePair(
System.String name, System.String value
			)
        {
            Framework.NameValuePair _retval = new Framework.NameValuePair();
				_retval.Name = name;
				_retval.Value = value;
            return _retval;
        }

		#endregion CreateNameValuePair(...)


		#region CreateRssItem(...)

        /// <summary>
        /// Creates a new instance of view RssItem.
        /// </summary>
        /// <returns>an instance of <see cref="Framework.RssItem"/></returns>
        public static Framework.RssItem CreateRssItem(
System.String title, System.String description, System.DateTime pubDate, System.String identifierInString
			)
        {
            Framework.RssItem _retval = new Framework.RssItem();
				_retval.Title = title;
				_retval.Description = description;
				_retval.PubDate = pubDate;
				_retval.IdentifierInString = identifierInString;
            return _retval;
        }

		#endregion CreateRssItem(...)


		#region CreateDefault(...)

        /// <summary>
        /// Creates a new instance of view Default.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Build.Default"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.Default CreateDefault(
System.Int64 id, System.Int32 solutionId, System.String name, System.String description, System.DateTime buildStartTime, System.String solution_1_Name
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Build.Default _retval = new MSBuildLogsExtended.DataSourceEntities.Build.Default();
				_retval.Id = id;
				_retval.SolutionId = solutionId;
				_retval.Name = name;
				_retval.Description = description;
				_retval.BuildStartTime = buildStartTime;
				_retval.Solution_1_Name = solution_1_Name;
            return _retval;
        }

		#endregion CreateDefault(...)


		#region CreateDefaultGroupedDataView(...)

        /// <summary>
        /// Creates a new instance of view DefaultGroupedDataView.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView CreateDefaultGroupedDataView(
System.Int32 solutionId, System.Int64 countPerFK, System.String name
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView _retval = new MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView();
				_retval.SolutionId = solutionId;
				_retval.CountPerFK = countPerFK;
				_retval.Name = name;
            return _retval;
        }

		#endregion CreateDefaultGroupedDataView(...)


		#region CreateUpdateNameRequest(...)

        /// <summary>
        /// Creates a new instance of view UpdateNameRequest.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest CreateUpdateNameRequest(
System.String name, System.Int64 id
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest _retval = new MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest();
				_retval.Name = name;
				_retval.Id = id;
            return _retval;
        }

		#endregion CreateUpdateNameRequest(...)


		#region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation CreateKeyInformation(
System.Int64 id, System.String name
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation _retval = new MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation();
				_retval.Id = id;
				_retval.Name = name;
            return _retval;
        }

		#endregion CreateKeyInformation(...)







	

	}

}