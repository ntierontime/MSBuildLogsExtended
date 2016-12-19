using System.Collections.Generic;
using System.Linq;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// collection class for entity <see cref="Build"/>
    /// </summary>
	public partial class BuildCollection : List<Build>
	{ 

		#region constructors

        /// <summary>
        ///  default constructors
        /// </summary>
		public BuildCollection(): base()
		{
		}

        /// <summary>
        /// constructor with IEnumerable input
        /// </summary>
        /// <param name="input">a set of <see cref="IEnumerable<Build"/></param>
        public BuildCollection(IEnumerable<Build> input)
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
			, System.Int32 solutionId
			, System.String name
			, System.String description
			, System.DateTime buildStartTime)
        {
            Build _Item = new Build(
				id
				, solutionId
				, name
				, description
				, buildStartTime			);
            this.Add(_Item);
        }

        #endregion Add(...)



        #region PrediacteByFKs

        /// <summary>
        /// Existses the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>true if any, otherwise false</returns>
		public bool ExistsByFKs(BuildQueryCriteriaByEntityReference criteria)
		{
            MSBuildLogsExtended.EntityContracts.QueryPredicateBuildByFKs<Build> _PrediacteByFKs = new MSBuildLogsExtended.EntityContracts.QueryPredicateBuildByFKs<Build>(criteria);
            return this.Count(_PrediacteByFKs.Predicate) > 0;
		}

        /// <summary>
        /// Gets the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>the first entity if any, otherwise null</returns>
        public Build GetByFKs(BuildQueryCriteriaByEntityReference criteria)
		{
            MSBuildLogsExtended.EntityContracts.QueryPredicateBuildByFKs<Build> _PrediacteByFKs = new MSBuildLogsExtended.EntityContracts.QueryPredicateBuildByFKs<Build>(criteria);
            return this.Single(_PrediacteByFKs.Predicate);
		}

        /// <summary>
        /// Gets the collection by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>a collection</returns>
        public BuildCollection GetCollectionByFKs(BuildQueryCriteriaByEntityReference criteria)
        {
            MSBuildLogsExtended.EntityContracts.QueryPredicateBuildByFKs<Build> _PrediacteByFKs = new MSBuildLogsExtended.EntityContracts.QueryPredicateBuildByFKs<Build>(criteria);
            return new BuildCollection(this.Where(_PrediacteByFKs.Predicate));
		}

        #endregion PrediacteByFKs


	}

		    /// <summary>

    /// <summary>
    ///  a property defined when <see cref="IBuildCollection"/> is used in other classes.
    /// </summary>
	public partial interface IBuildCollection
	{ 
        /// <summary>
        /// Gets or sets the BuildCollection
        /// </summary>
        /// <value>
        /// BuildCollection
        /// </value>
		BuildCollection BuildCollection { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildCollection"/> and <see cref="Framework.DataSourceEntities.DataAccessLayerMessageBase&lt;T&gt;"/> />
    /// </summary>
	public partial class DataAccessLayerMessageOfEntityCollectionBuild
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildCollection>
    {
    }


}