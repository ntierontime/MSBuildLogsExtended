using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{
    public class DataStreamServiceProviderBuild 
		: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection, MSBuildLogsExtended.DataSourceEntities.Build>
    {
        public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SolutionId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Description";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildStartTime";


        }

        public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.Build dataItem, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SolutionId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Description;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildStartTime;


        }


		public class Default 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.Build.Default>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Solution_S1_1_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SolutionId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Description";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildStartTime";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.Build.Default dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Solution_S1_1_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SolutionId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Description;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildStartTime;


			}
		}



		public class DefaultGroupedDataView 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection, MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SolutionId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CountPerFK";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SolutionId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CountPerFK;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;


			}
		}



		public class KeyInformation 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection, MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;


			}
		}



    }
}