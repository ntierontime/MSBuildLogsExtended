using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildLogsExtended.AspNetMvc40ApiController.ApiControllers.ApiControllers
{
    /// <summary>
    /// Api Controller of  <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog"/>
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/16/how-webapi-does-parameter-binding.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/20/how-to-bind-to-custom-objects-in-action-signatures-in-mvc-webapi.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/18/mvc-style-parameter-binding-for-webapi.aspx
    /// </summary>
    public partial class BuildLogApiController : ApiController
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.InsertEntity(input);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.UpdateEntity(input);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(identifier);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.DeleteEntity(input);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(new MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier(
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.BatchUpdate(input);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.BatchInsert(input);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.BatchDelete(input);

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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommonVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfCommon")]
        public int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfCommon")]
        public int GetPageCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfCommon")]
        public int GetCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfCommon")]
        public bool ExistsOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfCommon")]
        public int[] GetPageNumberListOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfCommon")]
        public int GetPageCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfCommon")]
        public int GetCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfCommon")]
        public bool ExistsOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAllVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfAll(				queryOrderByExpression);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfAll(				queryOrderByExpression);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfAll(				queryOrderByExpression);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByFKOnly")]
        public int[] GetPageNumberListOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByFKOnly")]
        public int GetPageCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfByFKOnly")]
        public int GetCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByFKOnly")]
        public bool ExistsOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfByFKOnly")]
        public int[] GetPageNumberListOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfByFKOnly")]
        public int GetPageCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfNameValuePairOfByFKOnly")]
        public int GetCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfByFKOnly")]
        public bool ExistsOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of RssItem of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfByFKOnly")]
        public int[] GetPageNumberListOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfByFKOnly")]
        public int GetPageCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfRssItemOfByFKOnly")]
        public int GetCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfByFKOnly")]
        public bool ExistsOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByFKOnly")]
        public int GetPageCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfByFKOnly")]
        public int GetCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByFKOnly")]
        public bool ExistsOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultGroupedDataViewOfByFKOnly")]
        public bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetPageCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.ExistsOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetMessageOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetSingleOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





    }
}

