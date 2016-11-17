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
using Microsoft.AspNetCore.Http;
using MSBuildLogsExtended.AspNetMvc40ViewModel;
using Framework.EntityContracts;

namespace MSBuildLogsExtended.AspNetMvc40Controller
{
    /// <summary>
	/// Cascading Dropdown: http://stackoverflow.com/questions/5497524/easiest-way-to-create-a-cascade-dropdown-in-asp-net-mvc-3-with-c-sharp
	/// Cascading Dropdown: http://code.msdn.microsoft.com/Cascading-DropDownList-in-833683f9
	/// Mvc Paging http://mvcpaging.apphb.com/
    /// Mvc Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.BuildEventCode"/>
    /// </summary>
    public partial class BuildEventCodeController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BuildEventCodeController));

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuildEventCode = "TempDataKey_WPCommonOfBuildEventCode";
		public ActionResult WPCommonOfBuildEventCode(int currentPage = 1 , WPCommonOfBuildEventCodeVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildEventCode", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildEventCode))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildEventCode];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);


            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfCommon(
                new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon(viewModel.Criteria)
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

        public ActionResult WPCommonOfBuildEventCode_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildEventCode_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildEventCode))
            {
                vmFromTempData = (Framework.EntityContracts.ViewModelBase<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildEventCode];

	            var searchResult = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfCommon(
		            new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon(vmFromTempData.Criteria)
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
		

        public ActionResult WPEntityRelatedOfBuildEventCode(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM vm = new MSBuildLogsExtended.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM(new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

   //     public ActionResult Import(HttpPostedFileBase file)
   //     {
			//ViewBag.FileFormat = "Id,EventCode,Description";
   //         if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
   //         {
   //             log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

   //             Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
   //             dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
   //             MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode dataStreamServiceProvider = new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode();
   //             MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

   //             if (collection != null)
   //             {
			//		MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection resultCollection = collection;
   //                 var result = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.BatchInsert(resultCollection);
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
            return RedirectToAction("WPCommonOfBuildEventCode");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/Details/5

        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            ViewBag.Message = "this is details";

            log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

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
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/Create
        public ActionResult AddNew()
        {
            ViewBag.Message = "to AddNew a new MSBuildLogsExtended.DataSourceEntities.BuildEventCode";



            MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity;
            if (TempData.ContainsKey(TempDataKey_BuildEventCodeController_Copy) && TempData[TempDataKey_BuildEventCodeController_Copy] != null)
            {
				try
				{
					entity = (MSBuildLogsExtended.DataSourceEntities.BuildEventCode)TempData[TempDataKey_BuildEventCodeController_Copy];
					TempData.Keep(TempDataKey_BuildEventCodeController_Copy);
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

            return View(entity);
        } 

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/AddNew
        [HttpPost]
        public ActionResult AddNew(MSBuildLogsExtended.DataSourceEntities.BuildEventCode input)
        {
            try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity = input;

                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.InsertEntity(entity);



				TempData[TempDataKey_BuildEventCodeController_Copy] = null;
                TempData.Remove(TempDataKey_BuildEventCodeController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildEventCode());
            }
        }
        
        public const string TempDataKey_BuildEventCodeController_Copy = "TempDataKey_BuildEventCodeController_Copy";
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildEventCodeController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildEventCodeController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/Edit/5
 
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));



            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildEventCode());
            }
        }

        //
        // POST: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/Edit/5

        [HttpPost]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildLogsExtended.DataSourceEntities.BuildEventCode input)
        {
            try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));
				MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity = input;

                //entity.Id = valueToCompareIdByIdentifierOftOfByIdentifier;


                var _Response = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.UpdateEntity(entity);



                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildEventCode());
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        //
        // GET: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/Delete/5

        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {

            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _Response =
                MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return View(_Response.Message[0]);
            }
            else
            {
                log.Error(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return View(new MSBuildLogsExtended.DataSourceEntities.BuildEventCode());
            } 
        }
		
  //      //
  //      // POST: /MSBuildLogsExtended.DataSourceEntities.BuildEventCode/Delete/5
		//[HttpPost]
  //      public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, FormCollection collection)
  //      {
  //          try
  //          {
  //              log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
		//		MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _Response =
		//			MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
		//		if (_Response != null && _Response.Message != null && _Response.Message.Count == 1)
		//		{
		//			MSBuildLogsExtended.DataSourceEntities.BuildEventCode input = _Response.Message[0];
		//			MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity = input;
  //                  MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.DeleteEntity(entity);
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
  //              return View(new MSBuildLogsExtended.DataSourceEntities.BuildEventCode());
  //          } 
  //      }

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

