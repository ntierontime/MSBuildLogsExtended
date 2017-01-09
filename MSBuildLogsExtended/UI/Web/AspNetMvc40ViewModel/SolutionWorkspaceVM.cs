using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40ViewModel
{

    public partial class WPCommonOfSolutionVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>
    {
        public WPCommonOfSolutionVM ()
            : base()
        {
        }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildLogsExtended.AspNetMvc40ViewModel.Common.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {

        }
    }




    public partial class WPEntityRelatedOfSolutionVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfSolutionVM(MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_Build_Solution = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly();
        }

		//FK_Build_Solution
		public MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly CriteriaOfFK_Build_Solution { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_Build_Solution { get; set; }
		public string StatusMessageOfFK_Build_Solution { get; set; }
		public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection FK_Build_Solution { get; set; }

        public void LoadData(
			bool isToLoadFK_Build_Solution = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
							// FK_Build_Solution
				if(isToLoadFK_Build_Solution)
				{
					this.CriteriaOfFK_Build_Solution.BuildQueryCriteriaByFKOnly.IdByFKOnlyOfSolution_1.IsToCompare = true;
					this.CriteriaOfFK_Build_Solution.BuildQueryCriteriaByFKOnly.IdByFKOnlyOfSolution_1.ValueToCompare = this.MasterEntity.Id;
					var resultFK_Build_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_Build_Solution, this.QueryPagingSetting, null);
					this.StatusOfFK_Build_Solution = resultFK_Build_Solution.BusinessLogicLayerResponseStatus;
					if (resultFK_Build_Solution.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.FK_Build_Solution = resultFK_Build_Solution.Message;
					}
					else
					{
						this.StatusMessageOfFK_Build_Solution = resultFK_Build_Solution.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfFK_Build_Solution = string.Format("{0} {1}", this.StatusMessageOfFK_Build_Solution, resultFK_Build_Solution.ServerErrorMessage);
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

