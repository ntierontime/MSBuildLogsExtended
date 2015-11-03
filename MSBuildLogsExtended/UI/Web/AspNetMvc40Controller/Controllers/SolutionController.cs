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
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.Solution"/>
    /// </summary>
    public partial class SolutionController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfSolution = "TempDataKey_WPCommonOfSolution";
		public ActionResult WPCommonOfSolution(int currentPage = 1 , WPCommonOfSolutionVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfSolution", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfSolution))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten>)TempData[TempDataKey_WPCommonOfSolution];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);


            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon(viewModel.Criteria)
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

        public ActionResult WPCommonOfSolution_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfSolution_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfSolution))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten>)TempData[TempDataKey_WPCommonOfSolution];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon(vmFromTempData.Criteria)
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
		

        public ActionResult WPEntityRelatedOfSolution(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Id,ExternalParentId,Name,Description";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution();
                MSBuildLogsExtended.DataSourceEntities.SolutionCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.SolutionCollection resultCollection = collection;
                    var result = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.BatchInsert(resultCollection);
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
            return RedirectToAction("WPCommonOfSolution");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Solution/Details/5

        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            ViewBag.Message = "this is details";

            log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

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

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Solution/Create
        public ActionResult AddNew()
        {
            ViewBag.Message = "to AddNew a new MSBuildLogsExtended.DataSourceEntities.Solution";



            MSBuildLogsExtended.DataSourceEntities.Solution entity;
            if (TempData.ContainsKey(TempDataKey_SolutionController_Copy) && TempData[TempDataKey_SolutionController_Copy] != null)
            {
				try
				{
					entity = (MSBuildLogsExtended.DataSourceEntities.Solution)TempData[TempDataKey_SolutionController_Copy];
					TempData.Keep(TempDataKey_SolutionController_Copy);
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

            return View(entity);
        } 

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.Solution/AddNew
        [HttpPost]
        public ActionResult AddNew(MSBuildLogsExtended.DataSourceEntities.Solution input)
        {
            try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.Solution entity = input;

                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.InsertEntity(entity);



				TempData[TempDataKey_SolutionController_Copy] = null;
                TempData.Remove(TempDataKey_SolutionController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.Solution());
            }
        }
        
        public const string TempDataKey_SolutionController_Copy = "TempDataKey_SolutionController_Copy";
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_SolutionController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_SolutionController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Solution/Edit/5
 
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));



            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.Solution());
            }
        }

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.Solution/Edit/5

        [HttpPost]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.DataSourceEntities.Solution input)
        {
            try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.DataSourceEntities.Solution entity = input;

                //entity.Id = valueToCompareIdByIdentifierOftOfByIdentifier;


                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.UpdateEntity(entity);



                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.Solution());
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Solution/Delete/5

        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {

            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.Solution());
            } 
        }
		
        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.Solution/Delete/5
		[HttpPost]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _Response =
					MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response != null && _Response.Message != null && _Response.Message.Count == 1)
				{
					MSBuildLogsExtended.DataSourceEntities.Solution input = _Response.Message[0];
					MSBuildLogsExtended.DataSourceEntities.Solution entity = input;
                    MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.DeleteEntity(entity);
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
                return View(new MSBuildLogsExtended.DataSourceEntities.Solution());
            } 
        }

		#endregion ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
		
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

