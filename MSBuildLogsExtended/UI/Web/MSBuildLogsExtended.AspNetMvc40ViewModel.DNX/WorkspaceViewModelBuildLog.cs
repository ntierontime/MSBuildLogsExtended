using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public class WPCommonOfBuildLogVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten, MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection>
    {
        public WPCommonOfBuildLogVM ()
            : base()
        {
        }
        public Framework.NameValueCollection NameValueCollectionOfMSBuildLogsExtended_Solution { get; set; }
        public List<SelectListItem> SelectListOfMSBuildLogsExtended_Solution { get; set; }
	
        public Framework.NameValueCollection NameValueCollectionOfMSBuildLogsExtended_BuildEventCode { get; set; }
        public List<SelectListItem> SelectListOfMSBuildLogsExtended_BuildEventCode { get; set; }
	
        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Build_B1_1_Name~ASC", "Build_B1_1_Name A-Z");
				list.Add("Build_B1_1_Name~DESC", "Build_B1_1_Name Z-A");
            return list;
        }

        public override void GetDefaultPerViewModel()
        {
            this.NameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildLogsExtended_Solution);
	
            this.NameValueCollectionOfMSBuildLogsExtended_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildLogsExtended_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildLogsExtended_BuildEventCode);
	
        }
    }




    public class WPEntityRelatedOfBuildLogVM 
		: Framework.Mvc.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildLogVM(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfBuild_B1_1 = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier();
			this.CriteriaOfSolution_S1_1 = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier();
			this.CriteriaOfBuildEventCode_B2_1 = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier();
        }

		//Build_B1_1
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier CriteriaOfBuild_B1_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuild_B1_1 { get; set; }
		public string StatusMessageOfBuild_B1_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation Build_B1_1 { get; set; }
		//Solution_S1_1
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier CriteriaOfSolution_S1_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_S1_1 { get; set; }
		public string StatusMessageOfSolution_S1_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation Solution_S1_1 { get; set; }
		//BuildEventCode_B2_1
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier CriteriaOfBuildEventCode_B2_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuildEventCode_B2_1 { get; set; }
		public string StatusMessageOfBuildEventCode_B2_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation BuildEventCode_B2_1 { get; set; }

        public void LoadData()
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting
							// MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild
				this.CriteriaOfBuild_B1_1.BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier.IdByIdentifierOft.IsToCompare = true;
				this.CriteriaOfBuild_B1_1.BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.BuildId;
                var resultBuild_B1_1 = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfBuild_B1_1, this.QueryPagingSettingOneRecord, null);
                this.StatusOfBuild_B1_1 = resultBuild_B1_1.BusinessLogicLayerResponseStatus;
                if (resultBuild_B1_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                {
                    this.Build_B1_1 = resultBuild_B1_1.Message[0];
                }
                else
                {
                    this.StatusMessageOfBuild_B1_1 = resultBuild_B1_1.GetStatusMessage();
#if DEBUG
                    this.StatusMessageOfBuild_B1_1 = string.Format("MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfBuild_B1_1, resultBuild_B1_1.ServerErrorMessage);
#endif
                }

							// MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution
				this.CriteriaOfSolution_S1_1.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft.IsToCompare = true;
				this.CriteriaOfSolution_S1_1.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.Solution_S1_1Id;
                var resultSolution_S1_1 = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfSolution_S1_1, this.QueryPagingSettingOneRecord, null);
                this.StatusOfSolution_S1_1 = resultSolution_S1_1.BusinessLogicLayerResponseStatus;
                if (resultSolution_S1_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                {
                    this.Solution_S1_1 = resultSolution_S1_1.Message[0];
                }
                else
                {
                    this.StatusMessageOfSolution_S1_1 = resultSolution_S1_1.GetStatusMessage();
#if DEBUG
                    this.StatusMessageOfSolution_S1_1 = string.Format("MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfSolution_S1_1, resultSolution_S1_1.ServerErrorMessage);
#endif
                }

							// MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode
				this.CriteriaOfBuildEventCode_B2_1.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft.IsToCompare = true;
				this.CriteriaOfBuildEventCode_B2_1.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.BuildEventCodeId;
                var resultBuildEventCode_B2_1 = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfBuildEventCode_B2_1, this.QueryPagingSettingOneRecord, null);
                this.StatusOfBuildEventCode_B2_1 = resultBuildEventCode_B2_1.BusinessLogicLayerResponseStatus;
                if (resultBuildEventCode_B2_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                {
                    this.BuildEventCode_B2_1 = resultBuildEventCode_B2_1.Message[0];
                }
                else
                {
                    this.StatusMessageOfBuildEventCode_B2_1 = resultBuildEventCode_B2_1.GetStatusMessage();
#if DEBUG
                    this.StatusMessageOfBuildEventCode_B2_1 = string.Format("MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfBuildEventCode_B2_1, resultBuildEventCode_B2_1.ServerErrorMessage);
#endif
                }


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree


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

