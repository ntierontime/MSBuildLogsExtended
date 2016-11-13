using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public class WPCommonOfBuildVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten, MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection>
    {
        public WPCommonOfBuildVM ()
            : base()
        {
        }
        public Framework.NameValueCollection NameValueCollectionOfMSBuildLogsExtended_Solution { get; set; }
        public List<SelectListItem> SelectListOfMSBuildLogsExtended_Solution { get; set; }
	
        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Solution_S1_1_Name~ASC", "Solution_S1_1_Name A-Z");
				list.Add("Solution_S1_1_Name~DESC", "Solution_S1_1_Name Z-A");
            return list;
        }

        public override void GetDefaultPerViewModel()
        {
            this.NameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildLogsExtended_Solution);
	
        }
    }




    public class WPEntityRelatedOfBuildVM 
		: Framework.Mvc.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildVM(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_BuildLog_Build = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly();
			this.CriteriaOfSolution_S1_1 = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier();
        }

		//FK_BuildLog_Build
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly CriteriaOfFK_BuildLog_Build { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_Build { get; set; }
		public string StatusMessageOfFK_BuildLog_Build { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_Build { get; set; }
		//Solution_S1_1
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier CriteriaOfSolution_S1_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_S1_1 { get; set; }
		public string StatusMessageOfSolution_S1_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation Solution_S1_1 { get; set; }

        public void LoadData()
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting
							// MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution
				this.CriteriaOfSolution_S1_1.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft.IsToCompare = true;
				this.CriteriaOfSolution_S1_1.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.SolutionId;
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


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
							// FK_BuildLog_Build
				this.CriteriaOfFK_BuildLog_Build.BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly.IdByFKOnlyOfBuild_B1_1.IsToCompare = true;
				this.CriteriaOfFK_BuildLog_Build.BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly.IdByFKOnlyOfBuild_B1_1.ValueToCompare = this.MasterEntity.Id;
                var resultFK_BuildLog_Build = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_BuildLog_Build, this.QueryPagingSetting, null);
                this.StatusOfFK_BuildLog_Build = resultFK_BuildLog_Build.BusinessLogicLayerResponseStatus;
                if (resultFK_BuildLog_Build.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                {
                    this.FK_BuildLog_Build = resultFK_BuildLog_Build.Message;
                }
                else
                {
                    this.StatusMessageOfFK_BuildLog_Build = resultFK_BuildLog_Build.GetStatusMessage();
#if DEBUG
                    this.StatusMessageOfFK_BuildLog_Build = string.Format("{0} {1}", this.StatusMessageOfFK_BuildLog_Build, resultFK_BuildLog_Build.ServerErrorMessage);
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

