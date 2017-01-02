using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{

    /// <summary>
    /// Build MS Chart of MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView
    /// </summary>
    public partial class BuildChartBuilderDefaultGroupedDataView: Framework.Charting.MSChartBuilder<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection, MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView>
    {
        #region 4.1. To Implement: Build X axis

        /// <summary>
        /// Builds the x Axis.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        protected override object BuildXAxis(MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView item)
        {
            return item.Name;
        }

        #endregion 4.1. Implement: Build X axis

        #region 4.2. Implement: Build Y axis

        /// <summary>
        /// Builds the y Axis.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        protected override double BuildYAxis(MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView item)
        {
            return item.CountPerFK;
        }

        #endregion 4.2. Implement: Build Y axis
    }


}