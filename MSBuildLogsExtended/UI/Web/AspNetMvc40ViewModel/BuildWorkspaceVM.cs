using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public partial class WPCommonOfBuildVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten, MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection>
    {
        public WPCommonOfBuildVM ()
            : base()
        {
        }
        public Framework.NameValueCollection NameValueCollectionOfMSBuildLogsExtended_Solution { get; set; }
        public List<SelectListItem> SelectListOfMSBuildLogsExtended_Solution { get; set; }
	
        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildLogsExtended.AspNetMvc40ViewModel.Common.OrderByLists.WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {
            this.NameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildLogsExtended_Solution);
	
        }
    }




    public partial class WPEntityRelatedOfBuildVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildVM(MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_BuildLog_Build = new MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly();
			this.CriteriaOfSolution_1 = new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier();
        }

		//FK_BuildLog_Build
		public MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly CriteriaOfFK_BuildLog_Build { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_Build { get; set; }
		public string StatusMessageOfFK_BuildLog_Build { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_Build { get; set; }
		//Solution_1
		public MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier CriteriaOfSolution_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1 { get; set; }
		public string StatusMessageOfSolution_1 { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation Solution_1 { get; set; }

        public void LoadData(
			bool isToLoadFK_BuildLog_Build = true
			, bool isToLoadSolution_1 = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting
							// MSBuildLogsExtended.CommonBLLIoC.IoCSolution
				if(isToLoadSolution_1)
				{
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.SolutionId;
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


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
							// FK_BuildLog_Build
				if(isToLoadFK_BuildLog_Build)
				{
					this.CriteriaOfFK_BuildLog_Build.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuild_1.IsToCompare = true;
					this.CriteriaOfFK_BuildLog_Build.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuild_1.ValueToCompare = this.MasterEntity.Id;
					var resultFK_BuildLog_Build = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_BuildLog_Build, this.QueryPagingSetting, null);
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




    public partial class WPUpdateNameOnlyOfBuildVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest, MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
		public WPUpdateNameOnlyOfBuildVM ()
            : base(new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier())
        {
        }
        public WPUpdateNameOnlyOfBuildVM(MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
		}

        public void LoadData()
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfUpdateNameRequestOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];
				this.StatusOfMasterEntity = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
				this.StatusMessageOfMasterEntity = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Description;
            }
            else
            {
                this.StatusMessageOfMasterEntity = masterEntityResult.GetStatusMessage();
#if DEBUG
                this.StatusMessageOfMasterEntity = string.Format("{0} {1}", this.StatusMessageOfMasterEntity, masterEntityResult.ServerErrorMessage);
#endif
            }
        }
        public void SaveData()
        {
            var request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly();
            request.Critieria = this.MasterEntity;
            var response = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.UpdateNameOnly(request);
            this.StatusOfMasterEntity = response.BusinessLogicLayerResponseStatus;
            if (this.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.StatusMessageOfMasterEntity = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Success; // Success
            }
            else
            {
                this.StatusMessageOfMasterEntity = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Failed; // failed
            }
        }
    }




}

