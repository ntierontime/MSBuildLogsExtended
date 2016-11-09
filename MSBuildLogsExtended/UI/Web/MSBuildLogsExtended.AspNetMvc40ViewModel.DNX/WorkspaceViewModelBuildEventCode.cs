using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public class WPCommonOfBuildEventCodeVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>
    {
        public WPCommonOfBuildEventCodeVM ()
            : base()
        {
        }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("EventCode~ASC", "EventCode A-Z");
				list.Add("EventCode~DESC", "EventCode Z-A");
            return list;
        }

        public override void GetDefaultPerViewModel()
        {

        }
    }




    public class WPEntityRelatedOfBuildEventCodeVM 
		: Framework.Mvc.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildEventCodeVM(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_BuildLog_BuildEventCode = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly();
        }

		//FK_BuildLog_BuildEventCode
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly CriteriaOfFK_BuildLog_BuildEventCode { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_BuildEventCode { get; set; }
		public string StatusMessageOfFK_BuildLog_BuildEventCode { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_BuildEventCode { get; set; }

        public void LoadData()
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
							// FK_BuildLog_BuildEventCode
				this.CriteriaOfFK_BuildLog_BuildEventCode.BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly.IdByFKOnlyOfBuildEventCode_B2_1.IsToCompare = true;
				this.CriteriaOfFK_BuildLog_BuildEventCode.BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly.IdByFKOnlyOfBuildEventCode_B2_1.ValueToCompare = this.MasterEntity.Id;
                var resultFK_BuildLog_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_BuildLog_BuildEventCode, this.QueryPagingSetting, null);
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

