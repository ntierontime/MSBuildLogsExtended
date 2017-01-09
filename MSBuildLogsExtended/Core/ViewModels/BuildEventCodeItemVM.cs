using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{
    public partial class BuildEventCodeItemVM : Framework.ViewModels.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeIdentifier, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>
    {

        public static BuildEventCodeItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            BuildEventCodeItemVM vm = new BuildEventCodeItemVM();

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn _Response =
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int32), valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
            }

            return vm;
        }

        public static BuildEventCodeItemVM CreateNewViewModel(MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            BuildEventCodeItemVM vm = new BuildEventCodeItemVM();
            vm.ContentData.Title = Framework.Resources.UIStringResource.AddNewAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.AddNew_BuildEventCode;

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }
	}
}

