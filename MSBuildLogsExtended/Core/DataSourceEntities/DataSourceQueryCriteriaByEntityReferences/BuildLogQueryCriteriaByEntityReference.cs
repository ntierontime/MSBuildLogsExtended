using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    ///  DataSourceQueryCriteriaByEntityReference of entity <see cref="MSBuildLogsExtended.BuildLog"/>
    /// </summary>
	public partial class BuildLogQueryCriteriaByEntityReference : MSBuildLogsExtended.EntityContracts.IQueryCriteriaBuildLogByFKs
	{
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByEntityReference"/> class.
        /// </summary>
		public BuildLogQueryCriteriaByEntityReference()
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public BuildLogQueryCriteriaByEntityReference(
bool isToCompareBuildId, System.Int64 comparedToBuildId
, bool isToCompareBuildEventCodeId, System.Int32 comparedToBuildEventCodeId)
		{

			this.IsToCompareBuildId = isToCompareBuildId;
            this.ComparedToBuildId = comparedToBuildId;


			this.IsToCompareBuildEventCodeId = isToCompareBuildEventCodeId;
            this.ComparedToBuildEventCodeId = comparedToBuildEventCodeId;

		}

		#endregion constructors

		#region properties

		public bool IsToCompareBuildId { get; set; }
		public System.Int64 ComparedToBuildId { get; set; }


		public bool IsToCompareBuildEventCodeId { get; set; }
		public System.Int32 ComparedToBuildEventCodeId { get; set; }

		
		#endregion properties

	}
}