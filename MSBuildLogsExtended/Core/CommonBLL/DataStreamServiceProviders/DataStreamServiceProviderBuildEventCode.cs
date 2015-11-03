using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{
    public class DataStreamServiceProviderBuildEventCode 
		: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>
    {
        public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "EventCode";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Description";


        }

        public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.BuildEventCode dataItem, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.EventCode;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Description;


        }


		public class KeyInformation 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection, MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;


			}
		}



    }
}