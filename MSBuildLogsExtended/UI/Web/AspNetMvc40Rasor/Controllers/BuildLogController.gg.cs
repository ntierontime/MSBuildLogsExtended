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
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog"/>
    /// </summary>
    public partial class BuildLogController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuildLog = "TempDataKey_WPCommonOfBuildLog";
        /// <summary>
        /// Controller Method of View WPCommonOfBuildLog : Description Of Common of MSBuildLogsExtended.BuildLog
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_WPCommonOfBuildLog)]
		public ActionResult WPCommonOfBuildLog(int currentPage = 1 ,string lowerBoundEventTimeCommonOftOfCommon = null, string upperBoundEventTimeCommonOftOfCommon = null, WPCommonOfBuildLogVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildLog", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildLog))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildLog];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

			viewModel.Criteria.LowerBoundEventTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundEventTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundEventTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundEventTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundEventTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundEventTimeCommonOftOfCommon);
            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon(viewModel.Criteria)
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

				TempData[TempDataKey_WPCommonOfBuildLog] = viewModel.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuildLog); 
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
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>(viewModel.Result, viewModel.QueryPagingSetting.CurrentPage, viewModel.QueryPagingSetting.PageSize, viewModel.QueryPagingSetting.CountOfRecords);
            }

			viewModel.ContentData.Title = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.BuildEventCode;
            viewModel.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Description;

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_WPCommonOfBuildLog)]
        public ActionResult WPCommonOfBuildLog_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildLog_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildLog))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildLog];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon(vmFromTempData.Criteria)
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
					, dataServiceType);

                var result = searchResult.DataStreamServiceResult;

				TempData[TempDataKey_WPCommonOfBuildLog] = vmFromTempData.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuildLog); 

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfBuildLog_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }





		#endregion Workspace Controller Methods : there are 1 workspace(s)
		

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_WPEntityRelatedOfBuildLog)]
        public ActionResult WPEntityRelatedOfBuildLog(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM(new MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Build_1_Name,Id,Solution_1Id,Solution_1_Name,BuildEventCode_1_Name,BuildId,BuildEventCodeId,Message,EventTime";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.BuildLogDataStreamService.Default dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.BuildLogDataStreamService.Default();
                MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildLogCollection resultCollection = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
					MSBuildLogsExtended.EntityContracts.IBuildLogHelper.CopyCollection<MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.BuildLogCollection, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(collection, resultCollection);
                    var result = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.BatchInsert(resultCollection);
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
        /// default page, redirect to "WPCommonBuildLog".
        /// </summary>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuildLog");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /BuildLog/Details/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Details)]
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DetailsAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Details_BuildLog;

            return View(vm);
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

		/// <summary>
        /// GET method of Adds the new <see cref="MSBuildLogsExtended.BuildLog"/>.
        /// GET: /BuildLog/AddNew 
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_AddNew)]
        public ActionResult AddNew()
        {
            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_BuildEventCode);


            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildLogController_Copy);

            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM.CreateNewViewModel(entity);

            return View(vm);
        } 

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildLogsExtended.BuildLog"/>.
        /// POST: /BuildLog/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_AddNew)]
        public ActionResult AddNew(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm)
        {
			try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.BuildLog entity = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(vm.Item);

                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.InsertEntity(entity);



				TempData[TempDataKey_BuildLogController_Copy] = null;
                TempData.Remove(TempDataKey_BuildLogController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_BuildLog_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildLogController_Copy);
                vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }
        
        public const string TempDataKey_BuildLogController_Copy = "TempDataKey_BuildLogController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildLogsExtended.BuildLog"/>, without identifier
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Copy)]
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildLogController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildLogController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildLogsExtended.BuildLog"/>.
        /// GET: /BuildLog/Edit/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_BuildEventCode);


            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Edit_BuildLog;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildLogsExtended.BuildLog"/>.
        /// POST: /BuildLog/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Edit)]
        public ActionResult Edit(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm)
        {
		    try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.BuildLog entity = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(vm.Item);
                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.UpdateEntity(entity);


                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_BuildLog_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Edit_BuildLog;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildLogsExtended.BuildLog"/>
        /// GET: /BuildLog/Delete/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Delete_BuildLog;
            return View(vm);
        }
		
        /// <summary>
        /// POST method of delete page of <see cref="MSBuildLogsExtended.BuildLog"/>
        /// POST: /BuildLog/Delete/5
        /// </summary>
        /// <returns></returns>
		[HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildLog_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildLog entity = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(vm.Item);
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.DeleteEntity(entity);
					log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("UrlStringsAlias.ActionName_BuildLog_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.Delete_BuildLog;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
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
            return RedirectToAction(UrlStringsAlias.ActionName_BuildLog_Index);
        }

		#endregion GoBackList()

        private MSBuildLogsExtended.DataSourceEntities.BuildLog.Default CreateEmptyEntityOrGetFromTempData(string tempDataKey_BuildLogController_Copy)
        {
            MSBuildLogsExtended.DataSourceEntities.BuildLog.Default entity;
            if (TempData.ContainsKey(tempDataKey_BuildLogController_Copy) && TempData[tempDataKey_BuildLogController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildLogsExtended.DataSourceEntities.BuildLog.Default)TempData[tempDataKey_BuildLogController_Copy];
                    TempData.Keep(tempDataKey_BuildLogController_Copy);
                }
                catch
                {
                    entity = new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default();
                }
            }
            else
            {
                entity = new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default();
            }

            return entity;
        }
    }
}

