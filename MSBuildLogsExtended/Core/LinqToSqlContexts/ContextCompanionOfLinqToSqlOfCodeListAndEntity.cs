using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace MSBuildLogsExtended.LinqToSqlContexts
{

    public partial class Build : MSBuildLogsExtended.EntityContracts.IBuild//, MSBuildLogsExtended.EntityContracts.IBuildIdentifier
    {

    }


    public partial class BuildEventCode : MSBuildLogsExtended.EntityContracts.IBuildEventCode//, MSBuildLogsExtended.EntityContracts.IBuildEventCodeIdentifier
    {

    }


    public partial class BuildLog : MSBuildLogsExtended.EntityContracts.IBuildLog//, MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier
    {

    }


    public partial class Solution : MSBuildLogsExtended.EntityContracts.ISolution//, MSBuildLogsExtended.EntityContracts.ISolutionIdentifier
    {

    }


}