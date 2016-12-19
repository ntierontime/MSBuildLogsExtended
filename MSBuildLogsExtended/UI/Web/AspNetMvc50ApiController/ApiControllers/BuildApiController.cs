using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildLogsExtended.AspNetMvc50ApiController.ApiControllers.ApiControllers
{
    /// <summary>
    /// Api Controller of  <see cref="CustomerInfo.DataSourceEntities.CustomerProduct"/>
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/16/how-webapi-does-parameter-binding.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/20/how-to-bind-to-custom-objects-in-action-signatures-in-mvc-webapi.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/18/mvc-style-parameter-binding-for-webapi.aspx
    /// </summary>
    public partial class BuildApiController : ApiController
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection,MSBuildLogsExtended.DataSourceEntities.Build,MSBuildLogsExtended.DataSourceEntities.BuildIdentifier> Members

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
		[HttpPost, ActionName("InsertEntity")]
        [System.Web.Http.Description.ResponseType(typeof(MSBuildLogsExtended.DataSourceEntities.Build))]
        public HttpResponseMessage InsertEntity(
            MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.InsertEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToInsert)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        [System.Web.Http.Description.ResponseType(typeof(MSBuildLogsExtended.DataSourceEntities.Build))]
        public HttpResponseMessage UpdateEntity(
            MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.UpdateEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToUpdate)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpDelete, ActionName("DeleteByIdentifierEntity")]
        public HttpResponseMessage DeleteByIdentifierEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildIdentifier identifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.DeleteByIdentifierEntity(identifier);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
			            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToDelete)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpDelete, ActionName("DeleteEntity")]
        public HttpResponseMessage DeleteEntity(
            MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.DeleteEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToDelete)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

		/// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
		[HttpDelete, ActionName("DeleteByIdentifier")]
        public HttpResponseMessage DeleteByIdentifier(
			System.Int64 id
			)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.DeleteByIdentifierEntity(new MSBuildLogsExtended.DataSourceEntities.BuildIdentifier(
				id));

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToDelete)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public HttpResponseMessage BatchUpdate(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.BatchUpdate(input);

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToUpdate)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpPost, ActionName("BatchInsert")]
        public HttpResponseMessage BatchInsert(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.BatchInsert(input);

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToInsert)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
            }
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpDelete, ActionName("BatchDelete")]
        public HttpResponseMessage BatchDelete(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.BatchDelete(input);

            if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                return Request.CreateResponse(HttpStatusCode.OK, responseMessage.Message);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.YouHaveNoPermissionToDelete)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, responseMessage.ServerErrorMessage);
            }
            else if (responseMessage.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.NoValueFromDataSource)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, responseMessage.ServerErrorMessage);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, responseMessage.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommonVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfCommon")]
        public int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfCommon")]
        public int GetPageCountOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfCommon")]
        public int GetCountOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfCommon")]
        public bool ExistsOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommonVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfCommon")]
        public int[] GetPageNumberListOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfCommon")]
        public int GetPageCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfCommon")]
        public int GetCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfCommon")]
        public bool ExistsOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommon")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultOfCommon(				isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareBuildStartTimeCommonOftOfCommon && lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon & lowerBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon & upperBoundBuildStartTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundBuildStartTimeCommonOftOfCommon
				, isToCompareNameCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedNameCommonOftOfCommon), valueToBeContainedNameCommonOftOfCommon
				, isToCompareDescriptionCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedDescriptionCommonOftOfCommon), valueToBeContainedDescriptionCommonOftOfCommon
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfAllVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAllVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfAllVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfAll")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfAll")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfAll(				queryOrderByExpression);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfNameValuePairOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfNameValuePairOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfNameValuePairOfAll(				queryOrderByExpression);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfRssItemOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfRssItemOfAll(				pageSize);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfRssItemOfAll(				currentIndex
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfRssItemOfAll(				queryOrderByExpression);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByFKOnly")]
        public int[] GetPageNumberListOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByFKOnly")]
        public int GetPageCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfByFKOnly")]
        public int GetCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByFKOnly")]
        public bool ExistsOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfByFKOnly")]
        public int[] GetPageNumberListOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfByFKOnly")]
        public int GetPageCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfNameValuePairOfByFKOnly")]
        public int GetCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfByFKOnly")]
        public bool ExistsOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of RssItem of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfByFKOnly")]
        public int[] GetPageNumberListOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfByFKOnly")]
        public int GetPageCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfRssItemOfByFKOnly")]
        public int GetCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfByFKOnly")]
        public bool ExistsOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByFKOnly")]
        public int GetPageCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfByFKOnly")]
        public int GetCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByFKOnly")]
        public bool ExistsOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultGroupedDataViewOfByFKOnly")]
        public bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of ByIdentifier per value type




        #region Query Methods Of UpdateNameRequest of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfUpdateNameRequestOfByIdentifierVM")]
        public int[] GetPageNumberListOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfUpdateNameRequestOfByIdentifierVM")]
        public int GetPageCountOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfUpdateNameRequestOfByIdentifierVM")]
        public int GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfUpdateNameRequestOfByIdentifierVM")]
        public bool ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfUpdateNameRequestOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfUpdateNameRequestOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfUpdateNameRequestOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfUpdateNameRequestOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of UpdateNameRequest of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfUpdateNameRequestOfByIdentifier")]
        public int[] GetPageNumberListOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfUpdateNameRequestOfByIdentifier")]
        public int GetPageCountOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
		[HttpGet, ActionName("GetCountOfUpdateNameRequestOfByIdentifier")]
        public int GetCountOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
		[HttpGet, ActionName("ExistsOfUpdateNameRequestOfByIdentifier")]
        public bool ExistsOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfUpdateNameRequestOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest"/></returns>
		[HttpGet, ActionName("GetMessageOfUpdateNameRequestOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfUpdateNameRequestOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetSingleOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfUpdateNameRequestOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier per value type




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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfKeyInformationOfByIdentifierVM")]
        public MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageNumberListOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetPageCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.ExistsOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetCollectionOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetMessageOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfKeyInformationOfByIdentifier")]
        public MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildLogsExtended.CommonBLLIoC.IoCBuild.GetSingleOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





		#region EntityUpdateActionSetting - UpdateNameOnly

        /// <summary>
        /// Update an entity of <see cref=" nTierCraftWhatever.DataSourceEntities.Organization"/> using data in MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest.
		/// Action Name: UpdateNameOnly
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("UpdateNameOnly")]
        public void UpdateNameOnly(MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Guid.NewGuid().ToString(), "1");
                request.Critieria = input;
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest responseMessage = MSBuildLogsExtended.CommonBLLIoC.IoCBuild.UpdateNameOnly(request);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

		#endregion EntityUpdateActionSetting - UpdateNameOnly



    }
}

