using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildLogsExtended.BuildEventCode
    /// </summary>
	public partial class BuildEventCodeResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>
    {

		#region Nested Views classes and their collection classes 1


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildLogsExtended.BuildEventCode
		/// </summary>
		public partial class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 1
    }
}