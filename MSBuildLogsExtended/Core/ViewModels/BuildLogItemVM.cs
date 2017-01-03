using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{
    public partial class BuildLogItemVM : Framework.EntityContracts.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>
    {
        public static BuildLogItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            BuildLogItemVM vm = new BuildLogItemVM();

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response =
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
            }

            return vm;
        }

        public static BuildLogItemVM CreateNewViewModel(MSBuildLogsExtended.DataSourceEntities.BuildLog.Default entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            BuildLogItemVM vm = new BuildLogItemVM();
            vm.ContentData.Title = Framework.Resources.UIStringResource.AddNewAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.AddNew_BuildLog;

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }
	}
}

