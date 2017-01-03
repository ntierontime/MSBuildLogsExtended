using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{
    public partial class SolutionItemVM : Framework.EntityContracts.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier, MSBuildLogsExtended.DataSourceEntities.Solution>
    {
        public static SolutionItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            SolutionItemVM vm = new SolutionItemVM();

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response =
                    MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int32), valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
            }

            return vm;
        }

        public static SolutionItemVM CreateNewViewModel(MSBuildLogsExtended.DataSourceEntities.Solution entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            SolutionItemVM vm = new SolutionItemVM();
            vm.ContentData.Title = Framework.Resources.UIStringResource.AddNewAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.AddNew_Solution;

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }
	}
}

