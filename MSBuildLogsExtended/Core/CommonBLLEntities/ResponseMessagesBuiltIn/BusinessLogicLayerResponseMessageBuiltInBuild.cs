using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildLogsExtended.Build
    /// </summary>
	public class BusinessLogicLayerResponseMessageBuiltInBuild
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection>
    {

		#region Nested Views classes and their collection classes 3


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildLogsExtended.Build
		/// </summary>
		public class Default
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view DefaultGroupedDataView of entity MSBuildLogsExtended.Build
		/// </summary>
		public class DefaultGroupedDataView
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildLogsExtended.Build
		/// </summary>
		public class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 3
    }
}