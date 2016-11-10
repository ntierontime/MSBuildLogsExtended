using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// provides some common methods/actions/stubs. 
    /// </summary>
    public static class DataSourceEntityHelperSolution
    {
		#region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Solution"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Solution CreateEntity(
			System.Int32 id
			,System.String externalParentId
			,System.String name
			,System.String description
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Solution _retval = new MSBuildLogsExtended.DataSourceEntities.Solution(
				id
				,externalParentId
				,name
				,description
				);
            return _retval;
        }

		#endregion CreateEntity(...)

		#region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildLogsExtended.DataSourceEntities.Solution item)
        {

        }


        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void ValidateValueBeforeSaveToDatabase(MSBuildLogsExtended.DataSourceEntities.SolutionCollection input)
        {
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildLogsExtended.DataSourceEntities.Solution _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

		#endregion ValidateValueBeforeSaveToDatabase(...)

		#region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void AssignEnityReferenceIDs(MSBuildLogsExtended.DataSourceEntities.SolutionCollection input)
		{
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildLogsExtended.DataSourceEntities.Solution _Item = input[i];

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
System.String title, System.String description, System.String identifierInString
			)
        {
            Framework.RssItem _retval = new Framework.RssItem();
				_retval.Title = title;
				_retval.Description = description;
				_retval.IdentifierInString = identifierInString;
            return _retval;
        }

		#endregion CreateRssItem(...)


		#region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation CreateKeyInformation(
System.Int32 id
			)
        {
            MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation _retval = new MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation();
				_retval.Id = id;
            return _retval;
        }

		#endregion CreateKeyInformation(...)







	

	}

}