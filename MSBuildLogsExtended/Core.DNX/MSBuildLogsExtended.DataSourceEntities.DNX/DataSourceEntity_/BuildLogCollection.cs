using System.Collections.Generic;
using System.Linq;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// collection class for entity <see cref="BuildLog"/>
    /// </summary>
	public partial class BuildLogCollection : List<BuildLog>
	{ 

		#region constructors

        /// <summary>
        ///  default constructors
        /// </summary>
		public BuildLogCollection(): base()
		{
		}

        /// <summary>
        /// constructor with IEnumerable input
        /// </summary>
        /// <param name="input">a set of <see cref="IEnumerable<BuildLog"/></param>
        public BuildLogCollection(IEnumerable<BuildLog> input)
            : base(input)
        {
        }

		#endregion constructors

        #region Add(...)

        /// <summary>
        /// add an item with parameters of .net value type for each property
        /// </summary>
        public void Add(
			System.Int64 id
			, System.Int64 buildId
			, System.Int32 buildEventCodeId
			, System.String message
			, System.DateTime eventTime)
        {
            BuildLog _Item = new BuildLog(
				id
				, buildId
				, buildEventCodeId
				, message
				, eventTime			);
            this.Add(_Item);
        }

        #endregion Add(...)



        #region PrediacteByFKs

        /// <summary>
        /// Existses the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>true if any, otherwise false</returns>
		public bool ExistsByFKs(DataSourceQueryCriteriaByEntityReferenceBuildLog criteria)
		{
            MSBuildLogsExtended.EntityContracts.QueryPredicateBuildLogByFKs<BuildLog> _PrediacteByFKs = new MSBuildLogsExtended.EntityContracts.QueryPredicateBuildLogByFKs<BuildLog>(criteria);
            return this.Count(_PrediacteByFKs.Predicate) > 0;
		}

        /// <summary>
        /// Gets the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>the first entity if any, otherwise null</returns>
        public BuildLog GetByFKs(DataSourceQueryCriteriaByEntityReferenceBuildLog criteria)
		{
            MSBuildLogsExtended.EntityContracts.QueryPredicateBuildLogByFKs<BuildLog> _PrediacteByFKs = new MSBuildLogsExtended.EntityContracts.QueryPredicateBuildLogByFKs<BuildLog>(criteria);
            return this.Single(_PrediacteByFKs.Predicate);
		}

        /// <summary>
        /// Gets the collection by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>a collection</returns>
        public BuildLogCollection GetCollectionByFKs(DataSourceQueryCriteriaByEntityReferenceBuildLog criteria)
        {
            MSBuildLogsExtended.EntityContracts.QueryPredicateBuildLogByFKs<BuildLog> _PrediacteByFKs = new MSBuildLogsExtended.EntityContracts.QueryPredicateBuildLogByFKs<BuildLog>(criteria);
            return new BuildLogCollection(this.Where(_PrediacteByFKs.Predicate));
		}

        #endregion PrediacteByFKs


	}

		    /// <summary>

    /// <summary>
    ///  a property defined when <see cref="IBuildLogCollection"/> is used in other classes.
    /// </summary>
	public interface IBuildLogCollection
	{ 
        /// <summary>
        /// Gets or sets the BuildLogCollection
        /// </summary>
        /// <value>
        /// BuildLogCollection
        /// </value>
		BuildLogCollection BuildLogCollection { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildLogCollection"/> and <see cref="Framework.DataSourceEntities.DataAccessLayerMessageBase&lt;T&gt;"/> />
    /// </summary>
	public class DataAccessLayerMessageOfEntityCollectionBuildLog
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildLogCollection>
    {
    }


}