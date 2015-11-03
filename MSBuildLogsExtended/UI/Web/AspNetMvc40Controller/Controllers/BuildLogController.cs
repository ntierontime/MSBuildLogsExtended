using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MSBuildLogsExtended.AspNetMvc40ViewModel;
using Framework.EntityContracts;

namespace MSBuildLogsExtended.AspNetMvc40Controller
{
    /// <summary>
	/// Cascading Dropdown: http://stackoverflow.com/questions/5497524/easiest-way-to-create-a-cascade-dropdown-in-asp-net-mvc-3-with-c-sharp
	/// Cascading Dropdown: http://code.msdn.microsoft.com/Cascading-DropDownList-in-833683f9
	/// Mvc Paging http://mvcpaging.apphb.com/
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog"/>
    /// </summary>
    public partial class BuildLogController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuildLog = "TempDataKey_WPCommonOfBuildLog";
		public ActionResult WPCommonOfBuildLog(int currentPage = 1 ,string lowerBoundEventTimeCommonOftOfCommon = null, string upperBoundEventTimeCommonOftOfCommon = null, WPCommonOfBuildLogVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildLog", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildLog))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildLog];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

			viewModel.Criteria.LowerBoundEventTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundEventTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundEventTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundEventTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundEventTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundEventTimeCommonOftOfCommon);
            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(viewModel.Criteria)
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

            return View(viewModel);
        }

        public ActionResult WPCommonOfBuildLog_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildLog_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildLog))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildLog];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(vmFromTempData.Criteria)
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
		

        public ActionResult WPEntityRelatedOfBuildLog(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Build_B1_1_Name,Id,Solution_S1_1Id,Solution_S1_1_Name,BuildEventCode_B2_1_Name,BuildId,BuildEventCodeId,Message,EventTime";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildLog.Default dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildLog.Default();
                MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildLogCollection resultCollection = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
					MSBuildLogsExtended.EntityContracts.IBuildLogHelper.CopyCollection<MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.BuildLogCollection, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(collection, resultCollection);
                    var result = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.BatchInsert(resultCollection);
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

        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuildLog");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildLog/Details/5

        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            ViewBag.Message = "this is details";

            log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.Message != null && _Response.Message.Count > 0)
            {
                log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View();
            }
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildLog/Create
        public ActionResult AddNew()
        {
            ViewBag.Message = "to AddNew a new MSBuildLogsExtended.DataSourceEntities.BuildLog";

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_BuildEventCode);


            MSBuildLogsExtended.DataSourceEntities.BuildLog.Default entity;
            if (TempData.ContainsKey(TempDataKey_BuildLogController_Copy) && TempData[TempDataKey_BuildLogController_Copy] != null)
            {
				try
				{
					entity = (MSBuildLogsExtended.DataSourceEntities.BuildLog.Default)TempData[TempDataKey_BuildLogController_Copy];
					TempData.Keep(TempDataKey_BuildLogController_Copy);
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

            return View(entity);
        } 

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.BuildLog/AddNew
        [HttpPost]
        public ActionResult AddNew(MSBuildLogsExtended.DataSourceEntities.BuildLog.Default input)
        {
            try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.BuildLog entity = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(input);

                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.InsertEntity(entity);



				TempData[TempDataKey_BuildLogController_Copy] = null;
                TempData.Remove(TempDataKey_BuildLogController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default());
            }
        }
        
        public const string TempDataKey_BuildLogController_Copy = "TempDataKey_BuildLogController_Copy";
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildLogController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildLogController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildLog/Edit/5
 
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_BuildEventCode = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_BuildEventCode);


            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default());
            }
        }

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.BuildLog/Edit/5

        [HttpPost]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default input)
        {
            try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.DataSourceEntities.BuildLog entity = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(input);

                //entity.Id = valueToCompareIdByIdentifierOftOfByIdentifier;


                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.UpdateEntity(entity);



                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default());
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildLog/Delete/5

        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {

            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default());
            } 
        }
		
        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.BuildLog/Delete/5
		[HttpPost]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response =
					MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response != null && _Response.Message != null && _Response.Message.Count == 1)
				{
					MSBuildLogsExtended.DataSourceEntities.BuildLog.Default input = _Response.Message[0];
					MSBuildLogsExtended.DataSourceEntities.BuildLog entity = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(input);
                    MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.DeleteEntity(entity);
					log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: DeleteByIdentifier, Entity not exists", Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default());
            } 
        }

		#endregion ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
		
		#region Binary Columns



        #endregion Binary Columns

		#region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction("Index");
        }

		#endregion GoBackList()
    }
}

