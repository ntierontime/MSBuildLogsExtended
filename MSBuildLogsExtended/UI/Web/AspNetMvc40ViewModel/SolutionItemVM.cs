using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{
    public partial class SolutionItemVM : Framework.Mvc.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier, MSBuildLogsExtended.DataSourceEntities.Solution>
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        public static SolutionItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            SolutionItemVM vm = new SolutionItemVM();

            try
            {
                log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildLogsExtended.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response =
                    MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByIdentifier(new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier), -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                    log.Info(string.Format("{0}: {1}", uiAction, Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                    log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));
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

