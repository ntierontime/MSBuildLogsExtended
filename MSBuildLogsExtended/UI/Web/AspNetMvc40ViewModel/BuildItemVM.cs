using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{
    public partial class BuildItemVM : Framework.Mvc.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.BuildIdentifier, MSBuildLogsExtended.DataSourceEntities.Build>
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        public static BuildItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            BuildItemVM vm = new BuildItemVM();

            try
            {
                log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response =
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByIdentifier(new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier), -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                    log.Info(string.Format("{0}: {1}", uiAction, Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                    log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));
            }

            return vm;
        }

        public static BuildItemVM CreateNewViewModel(MSBuildLogsExtended.DataSourceEntities.Build entity)
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

