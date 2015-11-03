using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{

    /// <summary>
    /// Build MS Chart of MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView
    /// </summary>
    public partial class ChartBuilderBuildLogDefaultGroupedDataView: Framework.Charting.MSChartBuilder<MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection, MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView>
    {
        #region 4.1. To Implement: Build X axis

        /// <summary>
        /// Builds the x Axis.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        protected override object BuildXAxis(MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView item)
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
        protected override double BuildYAxis(MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataView item)
        {
            return item.CountPerFK;
        }

        #endregion 4.2. Implement: Build Y axis
    }


}