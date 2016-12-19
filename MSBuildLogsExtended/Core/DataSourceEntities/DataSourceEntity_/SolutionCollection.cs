using System.Collections.Generic;
using System.Linq;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// collection class for entity <see cref="Solution"/>
    /// </summary>
	public partial class SolutionCollection : List<Solution>
	{ 

		#region constructors

        /// <summary>
        ///  default constructors
        /// </summary>
		public SolutionCollection(): base()
		{
		}

        /// <summary>
        /// constructor with IEnumerable input
        /// </summary>
        /// <param name="input">a set of <see cref="IEnumerable<Solution"/></param>
        public SolutionCollection(IEnumerable<Solution> input)
            : base(input)
        {
        }

		#endregion constructors

        #region Add(...)

        /// <summary>
        /// add an item with parameters of .net value type for each property
        /// </summary>
        public void Add(
			System.Int32 id
			, System.String externalParentId
			, System.String name
			, System.String description)
        {
            Solution _Item = new Solution(
				id
				, externalParentId
				, name
				, description			);
            this.Add(_Item);
        }

        #endregion Add(...)


	}

		    /// <summary>

    /// <summary>
    ///  a property defined when <see cref="ISolutionCollection"/> is used in other classes.
    /// </summary>
	public partial interface ISolutionCollection
	{ 
        /// <summary>
        /// Gets or sets the SolutionCollection
        /// </summary>
        /// <value>
        /// SolutionCollection
        /// </value>
		SolutionCollection SolutionCollection { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="SolutionCollection"/> and <see cref="Framework.DataSourceEntities.DataAccessLayerMessageBase&lt;T&gt;"/> />
    /// </summary>
	public partial class DataAccessLayerMessageOfEntityCollectionSolution
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<SolutionCollection>
    {
    }


}