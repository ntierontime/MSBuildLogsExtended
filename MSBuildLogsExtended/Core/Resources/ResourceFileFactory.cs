using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSBuildLogsExtended.Resources
{
    public static class ResourceFileFactory
    {
        public static MSBuildLogsExtended.Resources.UIStringResourcePerApp GetUIStringResourcePerAppInstance()
        {
            return new MSBuildLogsExtended.Resources.UIStringResourcePerApp();
        }
        public static MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild GetUIStringResourcePerEntityBuild()
        {
            return new MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild();
        }
        public static MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode GetUIStringResourcePerEntityBuildEventCode()
        {
            return new MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode();
        }
        public static MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog GetUIStringResourcePerEntityBuildLog()
        {
            return new MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog();
        }
        public static MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution GetUIStringResourcePerEntitySolution()
        {
            return new MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution();
        }
    }
}
