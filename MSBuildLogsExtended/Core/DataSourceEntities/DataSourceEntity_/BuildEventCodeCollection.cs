using System.Collections.Generic;
using System.Linq;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// collection class for entity <see cref="BuildEventCode"/>
    /// </summary>
	public partial class BuildEventCodeCollection : List<BuildEventCode>
	{ 

		#region constructors

        /// <summary>
        ///  default constructors
        /// </summary>
		public BuildEventCodeCollection(): base()
		{
		}

        /// <summary>
        /// constructor with IEnumerable input
        /// </summary>
        /// <param name="input">a set of <see cref="IEnumerable<BuildEventCode"/></param>
        public BuildEventCodeCollection(IEnumerable<BuildEventCode> input)
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
			, System.String eventCode
			, System.String description)
        {
            BuildEventCode _Item = new BuildEventCode(
				id
				, eventCode
				, description			);
            this.Add(_Item);
        }

        #endregion Add(...)


	}

		    /// <summary>

    /// <summary>
    ///  a property defined when <see cref="IBuildEventCodeCollection"/> is used in other classes.
    /// </summary>
	public interface IBuildEventCodeCollection
	{ 
        /// <summary>
        /// Gets or sets the BuildEventCodeCollection
        /// </summary>
        /// <value>
        /// BuildEventCodeCollection
        /// </value>
		BuildEventCodeCollection BuildEventCodeCollection { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildEventCodeCollection"/> and <see cref="Framework.DataSourceEntities.DataAccessLayerMessageBase&lt;T&gt;"/> />
    /// </summary>
	public class DataAccessLayerMessageOfEntityCollectionBuildEventCode
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildEventCodeCollection>
    {
    }


}