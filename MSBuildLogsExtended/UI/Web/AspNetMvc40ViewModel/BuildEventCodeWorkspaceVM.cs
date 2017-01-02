using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public partial class WPCommonOfBuildEventCodeVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>
    {
        public WPCommonOfBuildEventCodeVM ()
            : base()
        {
        }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildLogsExtended.AspNetMvc40ViewModel.Common.OrderByLists.WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {

        }
    }




    public partial class WPEntityRelatedOfBuildEventCodeVM 
		: Framework.Mvc.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildEventCodeVM(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_BuildLog_BuildEventCode = new MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly();
        }

		//FK_BuildLog_BuildEventCode
		public MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly CriteriaOfFK_BuildLog_BuildEventCode { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_BuildEventCode { get; set; }
		public string StatusMessageOfFK_BuildLog_BuildEventCode { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_BuildEventCode { get; set; }

        public void LoadData(
			bool isToLoadFK_BuildLog_BuildEventCode = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
							// FK_BuildLog_BuildEventCode
				if(isToLoadFK_BuildLog_BuildEventCode)
				{
					this.CriteriaOfFK_BuildLog_BuildEventCode.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuildEventCode_1.IsToCompare = true;
					this.CriteriaOfFK_BuildLog_BuildEventCode.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuildEventCode_1.ValueToCompare = this.MasterEntity.Id;
					var resultFK_BuildLog_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_BuildLog_BuildEventCode, this.QueryPagingSetting, null);
					this.StatusOfFK_BuildLog_BuildEventCode = resultFK_BuildLog_BuildEventCode.BusinessLogicLayerResponseStatus;
					if (resultFK_BuildLog_BuildEventCode.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.FK_BuildLog_BuildEventCode = resultFK_BuildLog_BuildEventCode.Message;
					}
					else
					{
						this.StatusMessageOfFK_BuildLog_BuildEventCode = resultFK_BuildLog_BuildEventCode.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfFK_BuildLog_BuildEventCode = string.Format("{0} {1}", this.StatusMessageOfFK_BuildLog_BuildEventCode, resultFK_BuildLog_BuildEventCode.ServerErrorMessage);
	#endif
					}
				}


				// 4. Major part - Article UIWorkspaceItemSetting - EntityReference/FK CrossJoin


            }
            else
            {
                this.StatusMessageOfMasterEntity = masterEntityResult.GetStatusMessage();
#if DEBUG
                this.StatusMessageOfMasterEntity = string.Format("{0} {1}", this.StatusMessageOfMasterEntity, masterEntityResult.ServerErrorMessage);
#endif
            }
        }
	}






}

