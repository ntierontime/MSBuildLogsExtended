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
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.Solution"/>
    /// </summary>
    public partial class SolutionController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfSolution = "TempDataKey_WPCommonOfSolution";
        /// <summary>
        /// Controller Method of View WPCommonOfSolution : Description Of Common of MSBuildLogsExtended.Solution
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_WPCommonOfSolution)]
		public ActionResult WPCommonOfSolution(int currentPage = 1 , WPCommonOfSolutionVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfSolution", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfSolution))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfSolution];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);


            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(viewModel.Criteria)
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

				TempData[TempDataKey_WPCommonOfSolution] = viewModel.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfSolution); 

				ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildLogsExtended.DataSourceEntities.Solution>(searchResult.Message, currentPage, searchResult.QueryPagingResult.PageSize, searchResult.QueryPagingResult.CountOfRecords);
			}
            else
            {
                viewModel.StatusMessageOfResult = searchResult.GetStatusMessage();
#if DEBUG
                viewModel.StatusMessageOfResult = string.Format("{0} {1}", viewModel.StatusMessageOfResult, searchResult.ServerErrorMessage);
#endif
            }

			if (viewModel.Result != null)
            {
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildLogsExtended.DataSourceEntities.Solution>(viewModel.Result, viewModel.QueryPagingSetting.CurrentPage, viewModel.QueryPagingSetting.PageSize, viewModel.QueryPagingSetting.CountOfRecords);
            }

			viewModel.ContentData.Title = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Solution;
            viewModel.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Description;

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_WPCommonOfSolution)]
        public ActionResult WPCommonOfSolution_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfSolution_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfSolution))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfSolution];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(vmFromTempData.Criteria)
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
					, dataServiceType);

                var result = searchResult.DataStreamServiceResult;

				TempData[TempDataKey_WPCommonOfSolution] = vmFromTempData.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfSolution); 

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfSolution_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }





		#endregion Workspace Controller Methods : there are 1 workspace(s)
		

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_WPEntityRelatedOfSolution)]
        public ActionResult WPEntityRelatedOfSolution(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Id,ExternalParentId,Name,Description";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.SolutionDataStreamService dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.SolutionDataStreamService();
                MSBuildLogsExtended.DataSourceEntities.SolutionCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.SolutionCollection resultCollection = collection;
                    var result = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.BatchInsert(resultCollection);
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
        /// default page, redirect to "WPCommonSolution".
        /// </summary>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfSolution");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /Solution/Details/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Details)]
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DetailsAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Details_Solution;

            return View(vm);
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

		/// <summary>
        /// GET method of Adds the new <see cref="MSBuildLogsExtended.Solution"/>.
        /// GET: /Solution/AddNew 
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_AddNew)]
        public ActionResult AddNew()
        {


            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_SolutionController_Copy);

            MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM.CreateNewViewModel(entity);

            return View(vm);
        } 

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildLogsExtended.Solution"/>.
        /// POST: /Solution/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_AddNew)]
        public ActionResult AddNew(MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm)
        {
			try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.Solution entity = vm.Item;

                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.InsertEntity(entity);



				TempData[TempDataKey_SolutionController_Copy] = null;
                TempData.Remove(TempDataKey_SolutionController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_Solution_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_SolutionController_Copy);
                vm = MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }
        
        public const string TempDataKey_SolutionController_Copy = "TempDataKey_SolutionController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildLogsExtended.Solution"/>, without identifier
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Copy)]
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response =
                MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_SolutionController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_SolutionController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildLogsExtended.Solution"/>.
        /// GET: /Solution/Edit/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {


            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Edit_Solution;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildLogsExtended.Solution"/>.
        /// POST: /Solution/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Edit)]
        public ActionResult Edit(MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm)
        {
		    try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.Solution entity = vm.Item;
                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.UpdateEntity(entity);


                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_Solution_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Edit_Solution;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildLogsExtended.Solution"/>
        /// GET: /Solution/Delete/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Delete_Solution;
            return View(vm);
        }
		
        /// <summary>
        /// POST method of delete page of <see cref="MSBuildLogsExtended.Solution"/>
        /// POST: /Solution/Delete/5
        /// </summary>
        /// <returns></returns>
		[HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.ExistsOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response)
                {
					MSBuildLogsExtended.DataSourceEntities.Solution entity = vm.Item;
                    MSBuildLogsExtended.CommonBLLIoC.IoCSolution.DeleteEntity(entity);
					log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("UrlStringsAlias.ActionName_Solution_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.Delete_Solution;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            } 
        }

		#endregion ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
		
		#region Binary Columns



        #endregion Binary Columns

		#region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction(UrlStringsAlias.ActionName_Solution_Index);
        }

		#endregion GoBackList()

        private MSBuildLogsExtended.DataSourceEntities.Solution CreateEmptyEntityOrGetFromTempData(string tempDataKey_SolutionController_Copy)
        {
            MSBuildLogsExtended.DataSourceEntities.Solution entity;
            if (TempData.ContainsKey(tempDataKey_SolutionController_Copy) && TempData[tempDataKey_SolutionController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildLogsExtended.DataSourceEntities.Solution)TempData[tempDataKey_SolutionController_Copy];
                    TempData.Keep(tempDataKey_SolutionController_Copy);
                }
                catch
                {
                    entity = new MSBuildLogsExtended.DataSourceEntities.Solution();
                }
            }
            else
            {
                entity = new MSBuildLogsExtended.DataSourceEntities.Solution();
            }

            return entity;
        }
    }
}

