using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MSBuildLogsExtended.EntityFrameworkContext
{


	#region partial class Build

    public partial class Build : MSBuildLogsExtended.EntityContracts.IBuild
    {

    }
	
	#endregion partial class Build



	#region partial class BuildEventCode

    public partial class BuildEventCode : MSBuildLogsExtended.EntityContracts.IBuildEventCode
    {

    }
	
	#endregion partial class BuildEventCode



	#region partial class BuildLog

    public partial class BuildLog : MSBuildLogsExtended.EntityContracts.IBuildLog
    {

    }
	
	#endregion partial class BuildLog



	#region partial class Solution

    public partial class Solution : MSBuildLogsExtended.EntityContracts.ISolution
    {

    }
	
	#endregion partial class Solution



}