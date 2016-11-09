using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Framework
{
    public static class AssemblyHelper
    {
        const string fmtStd = "{0}.{1}.{2}.{3}";

        public static string GetExecutingAssemblyVersionInString()
        {
            return GetAssemblyVersionInString(Assembly.GetEntryAssembly());
        }

        public static string GetAssemblyVersionInString(Assembly assembly)
        {
            Version version = assembly.GetName().Version;
            return string.Format(fmtStd, version.Major, version.Minor, version.Build, version.Revision);
        }
    }
}