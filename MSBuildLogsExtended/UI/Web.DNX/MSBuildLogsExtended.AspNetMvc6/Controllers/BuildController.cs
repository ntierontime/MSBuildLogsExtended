using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MSBuildLogsExtended.AspNetMvc40ViewModel;

namespace MSBuildLogsExtended.AspNetMvc40Controller
{
    /// <summary>
	/// Cascading Dropdown: http://stackoverflow.com/questions/5497524/easiest-way-to-create-a-cascade-dropdown-in-asp-net-mvc-3-with-c-sharp
	/// Cascading Dropdown: http://code.msdn.microsoft.com/Cascading-DropDownList-in-833683f9
	/// Mvc Paging http://mvcpaging.apphb.com/
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>
    /// </summary>
    public partial class BuildController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BuildController));

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuild = "TempDataKey_WPCommonOfBuild";
        public ActionResult WPCommonOfBuild(int currentPage = 1, string lowerBoundBuildStartTimeCommonOftOfCommon = null, string upperBoundBuildStartTimeCommonOftOfCommon = null, WPCommonOfBuildVM viewModel = null)
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
		

        public ActionResult WPEntityRelatedOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

   //     public ActionResult Import(HttpPostedFileBase file)
   //     {
			//ViewBag.FileFormat = "Solution_S1_1_Name,Id,SolutionId,Name,Description,BuildStartTime";
   //         if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
   //         {
   //             log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

   //             Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
   //             dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
   //             MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuild.Default dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuild.Default();
   //             MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

   //             if (collection != null)
   //             {
			//		MSBuildLogsExtended.DataSourceEntities.BuildCollection resultCollection = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
			//		MSBuildLogsExtended.EntityContracts.IBuildHelper.CopyCollection<MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.BuildCollection, MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(collection, resultCollection);
   //                 var result = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.BatchInsert(resultCollection);
			//		ViewBag.Message = Framework.Resources.UIStringResource.Data_Import_Success;
   //             }
   //             else
   //             {
   //                 ViewBag.Message = Framework.Resources.UIStringResource.Data_Import_NoRecordInSourceFile;
   //             }

   //             log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Ended.ToString()));

   //             return View();
   //         }
   //         else
   //         {
   //             ViewBag.Message = "";
   //             return View();
   //         }
   //     }

		#endregion Import()

		#region Index()

        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuild");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Build/Details/5

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

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Build/Create
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

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.Build/AddNew
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

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Build/Edit/5
 
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

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.Build/Edit/5

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

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.Build/Delete/5

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
		
  //      //
  //      // POST: /MSBuildLogsExtended.DataSourceEntities.Build/Delete/5
		//[HttpPost]
  //      public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, FormCollection collection)
  //      {
  //          try
  //          {
  //              log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
		//		MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default _Response =
		//			MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
		//		if (_Response != null && _Response.Message != null && _Response.Message.Count == 1)
		//		{
		//			MSBuildLogsExtended.DataSourceEntities.Build.Default input = _Response.Message[0];
		//			MSBuildLogsExtended.DataSourceEntities.Build entity = MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Build.Default, MSBuildLogsExtended.DataSourceEntities.Build>(input);
  //                  MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuild.DeleteEntity(entity);
		//			log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.UI_Process_Ended.ToString()));
  //              }
		//		else
		//		{
		//			log.Warn(string.Format("{0}: DeleteByIdentifier, Entity not exists", Framework.LoggingOptions.UI_Process_Ended.ToString()));
		//		}

  //              return RedirectToAction("Index");
  //          }
  //          catch
  //          {
  //              return View(new MSBuildLogsExtended.DataSourceEntities.Build.Default());
  //          } 
  //      }

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

