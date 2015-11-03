using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildLogsExtended.AspNetMvc40Controller.ApiControllers
{
    /// <summary>
    /// Api Controller of  <see cref="CustomerInfo.DataSourceEntities.CustomerProduct"/>
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/16/how-webapi-does-parameter-binding.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/20/how-to-bind-to-custom-objects-in-action-signatures-in-mvc-webapi.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/18/mvc-style-parameter-binding-for-webapi.aspx
    /// </summary>
    public class BuildLogApiController : ApiController
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildLogCollection,MSBuildLogsExtended.DataSourceEntities.BuildLog,MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier> Members

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
		[HttpPost, ActionName("InsertEntity")]
        public void InsertEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLog input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.InsertEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public void UpdateEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLog input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.UpdateEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpDelete, ActionName("DeleteByIdentifierEntity")]
        public void DeleteByIdentifierEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier identifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.DeleteByIdentifierEntity(identifier);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpDelete, ActionName("DeleteEntity")]
        public void DeleteEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLog input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.DeleteEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

		/// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
		[HttpDelete, ActionName("DeleteByIdentifier")]
        public void DeleteByIdentifier(
			System.Int64 id
			)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.DeleteByIdentifierEntity(new MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier(
				id));

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public void BatchUpdate(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.BatchUpdate(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpPost, ActionName("BatchInsert")]
        public void BatchInsert(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.BatchInsert(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpDelete, ActionName("BatchDelete")]
        public void BatchDelete(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog responseMessage = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.BatchDelete(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        #endregion batch insert, update and delete in an entity collection

        #endregion



        #region Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfCommonVM")]
        public int[] GetPageNumberListOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfCommonVM")]
        public int GetPageCountOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfCommonVM")]
        public int GetCountOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfCommonVM")]
        public bool ExistsOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommonVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfCommon")]
        public int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfCommon")]
        public int GetPageCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfCommon")]
        public int GetCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfCommon")]
        public bool ExistsOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of Common per value type




        #region Query Methods Of Default of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfCommonVM")]
        public int[] GetPageNumberListOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfCommonVM")]
        public int GetPageCountOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultOfCommonVM")]
        public int GetCountOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfCommonVM")]
        public bool ExistsOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfCommon")]
        public int[] GetPageNumberListOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfCommon")]
        public int GetPageCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfCommon")]
        public int GetCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfCommon")]
        public bool ExistsOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultOfCommon(				isToCompareIdCommonOfBuild_B1_1OfCommon && valueToCompareIdCommonOfBuild_B1_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_B1_1OfCommon
				, isToCompareIdCommonOfSolution_S1_1OfCommon && valueToCompareIdCommonOfSolution_S1_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_S1_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_B2_1OfCommon && valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of Common per value type




        #region Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfAllVM")]
        public int[] GetPageNumberListOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfAllVM")]
        public int GetPageCountOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfAllVM")]
        public int GetCountOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfAllVM")]
        public bool ExistsOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfAllVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAllVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfAllVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfAll")]
        public int[] GetPageNumberListOfEntityOfAll(
			int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfAll")]
        public int GetPageCountOfEntityOfAll(
			int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfAll")]
        public int GetCountOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfAll")]
        public bool ExistsOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfAll")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfAll")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfAll(				queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of All per value type




        #region Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfAllVM")]
        public int[] GetPageNumberListOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfAllVM")]
        public int GetPageCountOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfNameValuePairOfAllVM")]
        public int GetCountOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfAllVM")]
        public bool ExistsOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfAllVM")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfAllVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfAllVM")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfAll")]
        public int[] GetPageNumberListOfNameValuePairOfAll(
			int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfNameValuePairOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfAll")]
        public int GetPageCountOfNameValuePairOfAll(
			int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfNameValuePairOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfNameValuePairOfAll")]
        public int GetCountOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfAll")]
        public bool ExistsOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfAll")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfAll")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfAll")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfNameValuePairOfAll(				queryOrderByExpression);
		}

        #endregion Query Methods Of NameValuePair of All per value type




        #region Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfAllVM")]
        public int[] GetPageNumberListOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfAllVM")]
        public int GetPageCountOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfRssItemOfAllVM")]
        public int GetCountOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfAllVM")]
        public bool ExistsOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfAllVM")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfAllVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfAllVM")]
        public Framework.RssItemCollection GetSingleOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfAll")]
        public int[] GetPageNumberListOfRssItemOfAll(
			int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfRssItemOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfAll")]
        public int GetPageCountOfRssItemOfAll(
			int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfRssItemOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfRssItemOfAll")]
        public int GetCountOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfAll")]
        public bool ExistsOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfAll")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfAll")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfAll")]
        public Framework.RssItemCollection GetSingleOfRssItemOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfRssItemOfAll(				queryOrderByExpression);
		}

        #endregion Query Methods Of RssItem of All per value type




        #region Query Methods Of Entity of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByFKOnlyVM")]
        public int[] GetPageNumberListOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByFKOnlyVM")]
        public int GetPageCountOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfByFKOnlyVM")]
        public int GetCountOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByFKOnlyVM")]
        public bool ExistsOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByFKOnly")]
        public int[] GetPageNumberListOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByFKOnly")]
        public int GetPageCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfByFKOnly")]
        public int GetCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByFKOnly")]
        public bool ExistsOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of ByFKOnly per value type




        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfByFKOnlyVM")]
        public int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfByFKOnlyVM")]
        public int GetPageCountOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfNameValuePairOfByFKOnlyVM")]
        public int GetCountOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfByFKOnlyVM")]
        public bool ExistsOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnlyVM")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnlyVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfByFKOnlyVM")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfByFKOnly")]
        public int[] GetPageNumberListOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfByFKOnly")]
        public int GetPageCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfNameValuePairOfByFKOnly")]
        public int GetCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfByFKOnly")]
        public bool ExistsOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type




        #region Query Methods Of RssItem of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfByFKOnlyVM")]
        public int[] GetPageNumberListOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfByFKOnlyVM")]
        public int GetPageCountOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfRssItemOfByFKOnlyVM")]
        public int GetCountOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfByFKOnlyVM")]
        public bool ExistsOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnlyVM")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfByFKOnlyVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfByFKOnlyVM")]
        public Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of RssItem of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfByFKOnly")]
        public int[] GetPageNumberListOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfByFKOnly")]
        public int GetPageCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfRssItemOfByFKOnly")]
        public int GetCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfByFKOnly")]
        public bool ExistsOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of RssItem of ByFKOnly per value type




        #region Query Methods Of Default of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByFKOnlyVM")]
        public int[] GetPageNumberListOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByFKOnlyVM")]
        public int GetPageCountOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultOfByFKOnlyVM")]
        public int GetCountOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByFKOnlyVM")]
        public bool ExistsOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByFKOnly")]
        public int GetPageCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfByFKOnly")]
        public int GetCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByFKOnly")]
        public bool ExistsOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of ByFKOnly per value type




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public int GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultGroupedDataViewOfByFKOnly")]
        public bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per value type




        #region Query Methods Of Entity of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByIdentifierVM")]
        public int[] GetPageNumberListOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByIdentifierVM")]
        public int GetPageCountOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfByIdentifierVM")]
        public int GetCountOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByIdentifierVM")]
        public bool ExistsOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByIdentifier")]
        public int[] GetPageNumberListOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByIdentifier")]
        public int GetPageCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfByIdentifier")]
        public int GetCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByIdentifier")]
        public bool ExistsOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of ByIdentifier per value type




        #region Query Methods Of Default of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByIdentifierVM")]
        public int[] GetPageNumberListOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByIdentifierVM")]
        public int GetPageCountOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultOfByIdentifierVM")]
        public int GetCountOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByIdentifierVM")]
        public bool ExistsOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByIdentifier")]
        public int[] GetPageNumberListOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByIdentifier")]
        public int GetPageCountOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfByIdentifier")]
        public int GetCountOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByIdentifier")]
        public bool ExistsOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of ByIdentifier per value type




        #region Query Methods Of KeyInformation of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfKeyInformationOfByIdentifierVM")]
        public int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfKeyInformationOfByIdentifierVM")]
        public int GetPageCountOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfKeyInformationOfByIdentifierVM")]
        public int GetCountOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfKeyInformationOfByIdentifierVM")]
        public bool ExistsOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of KeyInformation of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfKeyInformationOfByIdentifier")]
        public int[] GetPageNumberListOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageNumberListOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfKeyInformationOfByIdentifier")]
        public int GetPageCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetPageCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfKeyInformationOfByIdentifier")]
        public int GetCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfKeyInformationOfByIdentifier")]
        public bool ExistsOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.ExistsOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetCollectionOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetMessageOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildLog.GetSingleOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





    }
}

