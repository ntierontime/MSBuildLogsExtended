using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MSBuildLogsExtended.AspNetMvc40ViewModel;
using Framework.EntityContracts;
using UrlStringsAlias = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.UrlStrings;

namespace MSBuildLogsExtended.AspNetMvc40Rasor.Controllers
{
    /// <summary>
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
    /// </summary>
    public partial class BuildController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuild = "TempDataKey_WPCommonOfBuild";
        /// <summary>
        /// Controller Method of View WPCommonOfBuild : Description Of Common of MSBuildLogsExtended.Build
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPCommonOfBuild)]
		public ActionResult WPCommonOfBuild(int currentPage = 1 ,string lowerBoundBuildStartTimeCommonOftOfCommon = null, string upperBoundBuildStartTimeCommonOftOfCommon = null, WPCommonOfBuildVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuild", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuild))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuild];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

			viewModel.Criteria.LowerBoundBuildStartTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundBuildStartTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundBuildStartTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundBuildStartTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundBuildStartTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundBuildStartTimeCommonOftOfCommon);
            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(viewModel.Criteria)
                , viewModel.QueryPagingSetting
                , viewModel.QueryOrderBySettingCollection);


            viewModel.StatusOfResult = searchResult.BusinessLogicLayerResponseStatus;

            if (viewModel.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				viewModel.Result = searchResult.Message;

				if (searchResult.QueryPagingResult != null)
				{
					viewModel.QueryPagingSetting.CountOfRecords = searchResult.QueryPagingResult.CountOfRecords;
					viewModel.QueryPagingSetting.RecordCountOfCurrentPage = searchResult.QueryPagingResult.RecordCountOfCurrentPage;
				}

				TempData[TempDataKey_WPCommonOfBuild] = viewModel.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuild); 
			}
            else
            {
                viewModel.StatusMessageOfResult = searchResult.GetStatusMessage();
#if DEBUG
                viewModel.StatusMessageOfResult = string.Format("{0} {1}", viewModel.StatusMessageOfResult, searchResult.ServerErrorMessage);
#endif
            }

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPCommonOfBuild)]
        public ActionResult WPCommonOfBuild_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuild_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuild))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuild];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(vmFromTempData.Criteria)
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
					, dataServiceType);

                var result = searchResult.DataStreamServiceResult;

				TempData[TempDataKey_WPCommonOfBuild] = vmFromTempData.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuild); 

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfBuild_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }





		#endregion Workspace Controller Methods : there are 1 workspace(s)
		

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPEntityRelatedOfBuild)]
        public ActionResult WPEntityRelatedOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM(new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }




		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPUpdateNameOnlyOfBuild)]
        public ActionResult WPUpdateNameOnlyOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {

            MSBuildLogsExtended.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM(new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }

        //
        // POST: /nTierCraftWhatever.DataSourceEntities.Organization/Edit/5

        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPUpdateNameOnlyOfBuild)]
        public ActionResult WPUpdateNameOnlyOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm)
        {

            if (vm != null)
            {
                vm.SaveData();
            }

            return View(vm);
        }




		#region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Solution_1_Name,Id,SolutionId,Name,Description,BuildStartTime";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.BuildDataStreamService.Default dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.BuildDataStreamService.Default();
                MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildCollection resultCollection = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					MSBuildLogsExtended.EntityContracts.IBuildHelper.CopyCollection<MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.BuildCollection, MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(collection, resultCollection);
                    var result = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.BatchInsert(resultCollection);
					ViewBag.Message = Framework.Resources.UIStringResource.Data_Import_Success;
                }
                else
                {
                    ViewBag.Message = Framework.Resources.UIStringResource.Data_Import_NoRecordInSourceFile;
                }

                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return View();
            }
            else
            {
                ViewBag.Message = "";
                return View();
            }
        }

		#endregion Import()

		#region Index()

        /// <summary>
        /// default page, redirect to "WPCommonBuild".
        /// </summary>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuild");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /Build/Details/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Details)]
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DetailsAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Details_Build;

            return View(vm);
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

		/// <summary>
        /// GET method of Adds the new <see cref="MSBuildLogsExtended.Build"/>.
        /// GET: /Build/AddNew 
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_AddNew)]
        public ActionResult AddNew()
        {
            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);


            MSBuildLogsExtended.DataSourceEntities.Build entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildController_Copy);

            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM.CreateNewViewModel(entity);

            return View(vm);
        } 

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildLogsExtended.Build"/>.
        /// POST: /Build/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_AddNew)]
        public ActionResult AddNew(MSBuildLogsExtended.DataSourceEntities.Build.Default input)
        {
			try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.Build entity = MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(input);

                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.InsertEntity(input.Item);



				TempData[TempDataKey_BuildController_Copy] = null;
                TempData.Remove(TempDataKey_BuildController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_Build_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildController_Copy);
                MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }
        
        public const string TempDataKey_BuildController_Copy = "TempDataKey_BuildController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildLogsExtended.Build"/>, without identifier
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Copy)]
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildLogsExtended.Build"/>.
        /// GET: /Build/Edit/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);


            Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus uiAction = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.Update;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Edit_Build;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildLogsExtended.Build"/>.
        /// POST: /Build/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.DataSourceEntities.Build.Default input)
        {
		    try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.UpdateEntity(vm.Item);


                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_Build_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Edit_Build;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildLogsExtended.Build"/>
        /// GET: /Build/Delete/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus uiAction = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.Delete;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Delete_Build;
            return View(vm);
        }
		
        /// <summary>
        /// POST method of delete page of <see cref="MSBuildLogsExtended.Build"/>
        /// POST: /Build/Delete/5
        /// </summary>
        /// <returns></returns>
		[HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response)
                {
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuild.DeleteEntity(vm.Item);
					log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("UrlStringsAlias.ActionName_Build_Index");
            }
            catch (Exception ex)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus uiAction = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.Delete;
                vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.Delete_Build;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            } 
        }

		#endregion ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
		
		#region Binary Columns



        #endregion Binary Columns

		#region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction(UrlStringsAlias.ActionName_Build_Index);
        }

		#endregion GoBackList()
    }
}

