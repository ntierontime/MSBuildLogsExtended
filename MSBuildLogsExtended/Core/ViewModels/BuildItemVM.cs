using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{
    public partial class BuildItemVM : Framework.EntityContracts.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.BuildIdentifier, MSBuildLogsExtended.DataSourceEntities.Build.Default>
    {
        public static BuildItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            BuildItemVM vm = new BuildItemVM();

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response =
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
            }

            return vm;
        }

        public static BuildItemVM CreateNewViewModel(MSBuildLogsExtended.DataSourceEntities.Build.Default entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            BuildItemVM vm = new BuildItemVM();
            vm.ContentData.Title = Framework.Resources.UIStringResource.AddNewAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.AddNew_Build;

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }
	}
}

