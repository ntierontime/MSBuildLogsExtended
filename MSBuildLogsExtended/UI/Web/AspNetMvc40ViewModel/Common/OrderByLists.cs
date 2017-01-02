using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel.Common
{
	public partial class OrderByLists
	{

		#region 1.1. MSBuildLogsExtended.Build.WPCommonOfBuild

        public static Framework.NameValueCollection WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Solution_1_Name~ASC", "Solution_1_Name A-Z");
				list.Add("Solution_1_Name~DESC", "Solution_1_Name Z-A");
            return list;
        }

		#endregion 1.1. MSBuildLogsExtended.Build.WPCommonOfBuild



		#region 2.1. MSBuildLogsExtended.BuildEventCode.WPCommonOfBuildEventCode

        public static Framework.NameValueCollection WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("EventCode~ASC", "EventCode A-Z");
				list.Add("EventCode~DESC", "EventCode Z-A");
            return list;
        }

		#endregion 2.1. MSBuildLogsExtended.BuildEventCode.WPCommonOfBuildEventCode



		#region 3.1. MSBuildLogsExtended.BuildLog.WPCommonOfBuildLog

        public static Framework.NameValueCollection WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Build_1_Name~ASC", "Build_1_Name A-Z");
				list.Add("Build_1_Name~DESC", "Build_1_Name Z-A");
            return list;
        }

		#endregion 3.1. MSBuildLogsExtended.BuildLog.WPCommonOfBuildLog



		#region 4.1. MSBuildLogsExtended.Solution.WPCommonOfSolution

        public static Framework.NameValueCollection WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("ExternalParentId~ASC", "ExternalParentId A-Z");
				list.Add("ExternalParentId~DESC", "ExternalParentId Z-A");
            return list;
        }

		#endregion 4.1. MSBuildLogsExtended.Solution.WPCommonOfSolution



	}
}

