using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildLogsExtended.Solution
    /// </summary>
	public partial class SolutionResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>
    {

		#region Nested Views classes and their collection classes 1


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildLogsExtended.Solution
		/// </summary>
		public partial class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 1
    }
}