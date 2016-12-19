using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildLogsExtended.BuildLog
    /// </summary>
	public partial class BuildLogResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildLogCollection>
    {

		#region Nested Views classes and their collection classes 3


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildLogsExtended.BuildLog
		/// </summary>
		public partial class Default
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view DefaultGroupedDataView of entity MSBuildLogsExtended.BuildLog
		/// </summary>
		public partial class DefaultGroupedDataView
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildLogsExtended.BuildLog
		/// </summary>
		public partial class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 3
    }
}