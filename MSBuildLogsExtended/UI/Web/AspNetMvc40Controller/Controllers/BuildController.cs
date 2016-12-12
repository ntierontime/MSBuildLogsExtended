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
        /// Search and display a list of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">The lower bound build start time common oft of common.</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">The upper bound build start time common oft of common.</param>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        public ActionResult WPCommonOfBuild(int currentPage = 1 ,string lowerBoundBuildStartTimeCommonOftOfCommon = null, string upperBoundBuildStartTimeCommonOftOfCommon = null, WPCommonOfBuildVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuild", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuild))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten>)TempData[TempDataKey_WPCommonOfBuild];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

			viewModel.Criteria.LowerBoundBuildStartTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundBuildStartTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundBuildStartTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundBuildStartTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundBuildStartTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundBuildStartTimeCommonOftOfCommon);
            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon(viewModel.Criteria)
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
        public ActionResult WPCommonOfBuild_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuild_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuild))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten>)TempData[TempDataKey_WPCommonOfBuild];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon(vmFromTempData.Criteria)
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
        /// Display one <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/> and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        public ActionResult WPEntityRelatedOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






        #region Import()

        /// <summary>
        /// Imports a list of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Solution_S1_1_Name,Id,SolutionId,Name,Description,BuildStartTime";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuild.Default dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuild.Default();
                MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildLogsExtended.DataSourceEntities.BuildCollection resultCollection = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					MSBuildLogsExtended.EntityContracts.IBuildHelper.CopyCollection<MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.BuildCollection, MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(collection, resultCollection);
                    var result = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.BatchInsert(resultCollection);
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
        /// default page, redirect to "WPCommonOfBuild".
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuild");
        }

        #endregion Index()

        #region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /MSBuildLogsExtended.DataSourceEntities.Build/Details/5
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            ViewBag.Message = "this is details";

            log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

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

        /// <summary>
        /// GET method of Adds the new <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// GET: /MSBuildLogsExtended.DataSourceEntities.Build/AddNew 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddNew()
        {
            ViewBag.Message = "to AddNew a new MSBuildLogsExtended.DataSourceEntities.Build";

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);


            MSBuildLogsExtended.DataSourceEntities.Build.Default entity;
            if (TempData.ContainsKey(TempDataKey_BuildController_Copy) && TempData[TempDataKey_BuildController_Copy] != null)
            {
				try
				{
					entity = (MSBuildLogsExtended.DataSourceEntities.Build.Default)TempData[TempDataKey_BuildController_Copy];
					TempData.Keep(TempDataKey_BuildController_Copy);
				}
				catch
				{
	                entity = new MSBuildLogsExtended.DataSourceEntities.Build.Default();
				}
            }
            else
            {
                entity = new MSBuildLogsExtended.DataSourceEntities.Build.Default();
            }

            return View(entity);
        }

        /// <summary>
        /// POST method of Adds the new <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// POST: /MSBuildLogsExtended.DataSourceEntities.Build/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddNew(MSBuildLogsExtended.DataSourceEntities.Build.Default input)
        {
            try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.Build entity = MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(input);

                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.InsertEntity(entity);



				TempData[TempDataKey_BuildController_Copy] = null;
                TempData.Remove(TempDataKey_BuildController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.Build.Default());
            }
        }
        
        public const string TempDataKey_BuildController_Copy = "TempDataKey_BuildController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>, without identifier
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

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
        /// GET method of editing page of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
        /// GET: /MSBuildLogsExtended.DataSourceEntities.Build/Edit/5
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.NameValueCollection nameValueCollectionOfMSBuildLogsExtended_Solution = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticSolution.GetCollectionOfNameValuePairOfAll(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildLogsExtended_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildLogsExtended_Solution);


            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.Build.Default());
            }
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
        /// POST: /MSBuildLogsExtended.DataSourceEntities.Build/Edit/5
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.DataSourceEntities.Build.Default input)
        {
            try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.DataSourceEntities.Build entity = MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(input);

                //entity.Id = valueToCompareIdByIdentifierOftOfByIdentifier;


                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.UpdateEntity(entity);



                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.Build.Default());
            }
        }

        #endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        #region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
        /// GET: /MSBuildLogsExtended.DataSourceEntities.Build/Delete/5
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {

            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.Build.Default());
            } 
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
        /// POST: /MSBuildLogsExtended.DataSourceEntities.Build/Delete/5
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">if set to <c>true</c> [is to compare identifier by identifier oft of by identifier].</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">The value to compare identifier by identifier oft of by identifier.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default _Response =
					MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response != null && _Response.Message != null && _Response.Message.Count == 1)
				{
					MSBuildLogsExtended.DataSourceEntities.Build.Default input = _Response.Message[0];
					MSBuildLogsExtended.DataSourceEntities.Build entity = MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(input);
                    MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.DeleteEntity(entity);
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
                return View(new MSBuildLogsExtended.DataSourceEntities.Build.Default());
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

