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
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.BuildEventCode"/>
    /// </summary>
    public partial class BuildEventCodeController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)

		
		public const string TempDataKey_WPCommonOfBuildEventCode = "TempDataKey_WPCommonOfBuildEventCode";
        /// <summary>
        /// Controller Method of View WPCommonOfBuildEventCode : Description Of Common of MSBuildLogsExtended.BuildEventCode
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_WPCommonOfBuildEventCode)]
		public ActionResult WPCommonOfBuildEventCode(int currentPage = 1 , WPCommonOfBuildEventCodeVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildEventCode", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildEventCode))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildEventCode];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);


            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon(viewModel.Criteria)
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

				TempData[TempDataKey_WPCommonOfBuildEventCode] = viewModel.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuildEventCode);
                
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildLogsExtended.DataSourceEntities.BuildEventCode>(searchResult.Message, currentPage, searchResult.QueryPagingResult.PageSize, searchResult.QueryPagingResult.CountOfRecords);

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
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_WPCommonOfBuildEventCode)]
        public ActionResult WPCommonOfBuildEventCode_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildEventCode_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildEventCode))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildEventCode];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon(vmFromTempData.Criteria)
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
					, dataServiceType);

                var result = searchResult.DataStreamServiceResult;

				TempData[TempDataKey_WPCommonOfBuildEventCode] = vmFromTempData.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuildEventCode); 

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfBuildEventCode_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }



		#endregion Workspace Controller Methods : there are 1 workspace(s)
		
        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_WPEntityRelatedOfBuildEventCode)]
        public ActionResult WPEntityRelatedOfBuildEventCode(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM(new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }


		#region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Id,EventCode,Description";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.BuildEventCodeDataStreamService dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.BuildEventCodeDataStreamService();
                MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection resultCollection = collection;
                    var result = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.BatchInsert(resultCollection);
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
        /// default page, redirect to "WPCommonBuildEventCode".
        /// </summary>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuildEventCode");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /BuildEventCode/Details/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Details)]
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DetailsAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Details_BuildEventCode;

            return View(vm);
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

		/// <summary>
        /// GET method of Adds the new <see cref="MSBuildLogsExtended.BuildEventCode"/>.
        /// GET: /BuildEventCode/AddNew 
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_AddNew)]
        public ActionResult AddNew()
        {


            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildEventCodeController_Copy);

            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM.CreateNewViewModel(entity);

            return View(vm);
        } 

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildLogsExtended.BuildEventCode"/>.
        /// POST: /BuildEventCode/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_AddNew)]
        public ActionResult AddNew(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm)
        {
			try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity = vm.Item;

                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.InsertEntity(entity);


				TempData[TempDataKey_BuildEventCodeController_Copy] = null;
                TempData.Remove(TempDataKey_BuildEventCodeController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_BuildEventCode_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildEventCodeController_Copy);
                vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }
        
        public const string TempDataKey_BuildEventCodeController_Copy = "TempDataKey_BuildEventCodeController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildLogsExtended.BuildEventCode"/>, without identifier
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Copy)]
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn _Response =
                MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildEventCodeController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildEventCodeController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildLogsExtended.BuildEventCode"/>.
        /// GET: /BuildEventCode/Edit/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {


            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Edit_BuildEventCode;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildLogsExtended.BuildEventCode"/>.
        /// POST: /BuildEventCode/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Edit)]
        public ActionResult Edit(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm)
        {
		    try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity = vm.Item;
                var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.UpdateEntity(entity);

                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_BuildEventCode_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Edit_BuildEventCode;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildLogsExtended.BuildEventCode"/>
        /// GET: /BuildEventCode/Delete/5
        /// </summary>
        /// <returns></returns>
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
            vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Delete_BuildEventCode;
            return View(vm);
        }
		
        /// <summary>
        /// POST method of delete page of <see cref="MSBuildLogsExtended.BuildEventCode"/>
        /// POST: /BuildEventCode/Delete/5
        /// </summary>
        /// <returns></returns>
		[HttpPost]
		[MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				var _Response = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.ExistsOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity = vm.Item;
                    MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.DeleteEntity(entity);
					log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("UrlStringsAlias.ActionName_BuildEventCode_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
                vm.ContentData.Summary = MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.Delete_BuildEventCode;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildLogsExtended.AspNetMvc40ViewModel.BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
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
            return RedirectToAction(UrlStringsAlias.ActionName_BuildEventCode_Index);
        }

		#endregion GoBackList()

        private MSBuildLogsExtended.DataSourceEntities.BuildEventCode CreateEmptyEntityOrGetFromTempData(string tempDataKey_BuildEventCodeController_Copy)
        {
            MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity;
            if (TempData.ContainsKey(tempDataKey_BuildEventCodeController_Copy) && TempData[tempDataKey_BuildEventCodeController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildLogsExtended.DataSourceEntities.BuildEventCode)TempData[tempDataKey_BuildEventCodeController_Copy];
                    TempData.Keep(tempDataKey_BuildEventCodeController_Copy);
                }
                catch
                {
                    entity = new MSBuildLogsExtended.DataSourceEntities.BuildEventCode();
                }
            }
            else
            {
                entity = new MSBuildLogsExtended.DataSourceEntities.BuildEventCode();
            }

            return entity;
        }
    }
}
