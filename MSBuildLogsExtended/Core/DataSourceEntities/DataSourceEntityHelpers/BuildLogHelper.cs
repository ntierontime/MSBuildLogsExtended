using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// provides some common methods/actions/stubs. 
    /// </summary>
    public static partial class BuildLogHelper
    {
		#region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog CreateEntity(
			System.Int64 id
			,System.Int64 buildId
			,System.Int32 buildEventCodeId
			,System.String message
			,System.DateTime eventTime
			)
        {
            MSBuildLogsExtended.DataSourceEntities.BuildLog _retval = new MSBuildLogsExtended.DataSourceEntities.BuildLog(
				id
				,buildId
				,buildEventCodeId
				,message
				,eventTime
				);
            return _retval;
        }

		#endregion CreateEntity(...)

		#region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildLogsExtended.DataSourceEntities.BuildLog item)
        {
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.EventTime < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.EventTime = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}

        }


        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void ValidateValueBeforeSaveToDatabase(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildLogsExtended.DataSourceEntities.BuildLog _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

		#endregion ValidateValueBeforeSaveToDatabase(...)

		#region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void AssignEnityReferenceIDs(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input, System.Int64 buildId, System.Int32 buildEventCodeId)
		{
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildLogsExtended.DataSourceEntities.BuildLog _Item = input[i];
				_Item.BuildId = buildId;
				_Item.BuildEventCodeId = buildEventCodeId;
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
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.Default"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.Default CreateDefault(
System.Int64 id, System.Int64 buildId, System.Int32 buildEventCodeId, System.String message, System.DateTime eventTime, System.String build_1_Name, System.String solution_1_Name, System.Int32 solution_1Id, System.String buildEventCode_1_Name
			)
        {
            MSBuildLogsExtended.DataSourceEntities.BuildLog.Default _retval = new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default();
				_retval.Id = id;
				_retval.BuildId = buildId;
				_retval.BuildEventCodeId = buildEventCodeId;
				_retval.Message = message;
				_retval.EventTime = eventTime;
				_retval.Build_1_Name = build_1_Name;
				_retval.Solution_1_Name = solution_1_Name;
				_retval.Solution_1Id = solution_1Id;
				_retval.BuildEventCode_1_Name = buildEventCode_1_Name;
            return _retval;
        }

		#endregion CreateDefault(...)


		#region CreateDefaultGroupedDataView(...)

        /// <summary>
        /// Creates a new instance of view DefaultGroupedDataView.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView CreateDefaultGroupedDataView(
System.Int64 buildId, System.Int32 buildEventCodeId, System.Int32 solution_1Id, System.Int64 countPerFK, System.String name
			)
        {
            MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView _retval = new MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView();
				_retval.BuildId = buildId;
				_retval.BuildEventCodeId = buildEventCodeId;
				_retval.Solution_1Id = solution_1Id;
				_retval.CountPerFK = countPerFK;
				_retval.Name = name;
            return _retval;
        }

		#endregion CreateDefaultGroupedDataView(...)


		#region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformation"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformation CreateKeyInformation(
System.Int64 id, System.Int32 buildEventCodeId
			)
        {
            MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformation _retval = new MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformation();
				_retval.Id = id;
				_retval.BuildEventCodeId = buildEventCodeId;
            return _retval;
        }

		#endregion CreateKeyInformation(...)







	

	}

}