using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public partial class WPCommonOfBuildLogVM : Framework.ViewModels.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten, MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection>
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
            return MSBuildLogsExtended.AspNetMvc40ViewModel.Common.OrderByLists.WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {
            this.NameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildLogsExtended_Solution);
	
            this.NameValueCollectionOfMSBuildLogsExtended_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildLogsExtended_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildLogsExtended_BuildEventCode);
	
        }
    }




    public partial class WPEntityRelatedOfBuildLogVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildLogVM(MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfBuild_1 = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier();
			this.CriteriaOfSolution_1 = new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier();
			this.CriteriaOfBuildEventCode_1 = new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier();
        }

		//Build_1
		public MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier CriteriaOfBuild_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuild_1 { get; set; }
		public string StatusMessageOfBuild_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation Build_1 { get; set; }
		//Solution_1
		public MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier CriteriaOfSolution_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1 { get; set; }
		public string StatusMessageOfSolution_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation Solution_1 { get; set; }
		//BuildEventCode_1
		public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier CriteriaOfBuildEventCode_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuildEventCode_1 { get; set; }
		public string StatusMessageOfBuildEventCode_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation BuildEventCode_1 { get; set; }

        public void LoadData(
			bool isToLoadBuild_1 = true
			, bool isToLoadSolution_1 = true
			, bool isToLoadBuildEventCode_1 = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting
							// MSBuildLogsExtended.CommonBLLIoC.IoCBuild
				if(isToLoadBuild_1)
				{
					this.CriteriaOfBuild_1.BuildQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfBuild_1.BuildQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.BuildId;
					var resultBuild_1 = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfBuild_1, this.QueryPagingSettingOneRecord, null);
					this.StatusOfBuild_1 = resultBuild_1.BusinessLogicLayerResponseStatus;
					if (resultBuild_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.Build_1 = resultBuild_1.Message[0];
					}
					else
					{
						this.StatusMessageOfBuild_1 = resultBuild_1.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfBuild_1 = string.Format("MSBuildLogsExtended.CommonBLLIoC.IoCBuild GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfBuild_1, resultBuild_1.ServerErrorMessage);
	#endif
					}
				}

							// MSBuildLogsExtended.CommonBLLIoC.IoCSolution
				if(isToLoadSolution_1)
				{
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.Solution_1Id;
					var resultSolution_1 = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfSolution_1, this.QueryPagingSettingOneRecord, null);
					this.StatusOfSolution_1 = resultSolution_1.BusinessLogicLayerResponseStatus;
					if (resultSolution_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.Solution_1 = resultSolution_1.Message[0];
					}
					else
					{
						this.StatusMessageOfSolution_1 = resultSolution_1.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfSolution_1 = string.Format("MSBuildLogsExtended.CommonBLLIoC.IoCSolution GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfSolution_1, resultSolution_1.ServerErrorMessage);
	#endif
					}
				}

							// MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode
				if(isToLoadBuildEventCode_1)
				{
					this.CriteriaOfBuildEventCode_1.BuildEventCodeQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfBuildEventCode_1.BuildEventCodeQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.BuildEventCodeId;
					var resultBuildEventCode_1 = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfBuildEventCode_1, this.QueryPagingSettingOneRecord, null);
					this.StatusOfBuildEventCode_1 = resultBuildEventCode_1.BusinessLogicLayerResponseStatus;
					if (resultBuildEventCode_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.BuildEventCode_1 = resultBuildEventCode_1.Message[0];
					}
					else
					{
						this.StatusMessageOfBuildEventCode_1 = resultBuildEventCode_1.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfBuildEventCode_1 = string.Format("MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfBuildEventCode_1, resultBuildEventCode_1.ServerErrorMessage);
	#endif
					}
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

