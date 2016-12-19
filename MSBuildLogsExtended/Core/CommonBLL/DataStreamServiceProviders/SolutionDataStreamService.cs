using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{
    public class SolutionDataStreamService 
		: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection, MSBuildLogsExtended.DataSourceEntities.Solution>
    {
        public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ExternalParentId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Description";


        }

        public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.Solution dataItem, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ExternalParentId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Description;


        }


		public class KeyInformation 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection, MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;


			}
		}



    }
}