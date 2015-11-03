using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Framework.EntityContracts;
using Framework;

namespace MSBuildLogsExtended.CommonBLLIoC
{
    /// <summary>
    /// provides static method wrappers of Business logic layer using IoC
    /// </summary>
	//[System.ComponentModel.DataObject], because of Silverlight and Windows Phone 7.1
    public static class BusinessLogicLayerEntityStaticBuildLog
    {
        #region insert, update and delete in request message

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog InsertRequest(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.InsertEntity(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog UpdateRequest(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.UpdateEntity(_Request);
        }

        /// <summary>
        /// Deletes By Identifier an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteByIdentifierRequest(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.DeleteByIdentifierEntity(_Request);
        }

        /// <summary>
        /// Deletes an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteRequest(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.DeleteEntity(_Request);
        }

        #endregion insert, update and delete in request message
		
        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog InsertEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLog input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request =new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Request.Critieria.Add(input);
            return InsertRequest(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog UpdateEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLog input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Request.Critieria.Add(input);
            return UpdateRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteByIdentifierEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier identifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = identifier;
            return DeleteByIdentifierRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildLog input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Request.Critieria.Add(input);
            return DeleteRequest(_Request);
        }

        #endregion insert, update and delete in an entity

        #region insert, update and delete using .Net value types

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="buildId">property value of System.Int64</param>
        /// <param name="buildEventCodeId">property value of System.Int32</param>
        /// <param name="message">property value of System.String</param>
        /// <param name="eventTime">property value of System.DateTime</param>
        public static void Insert(
			System.Int64 id
			, System.Int64 buildId
			, System.Int32 buildEventCodeId
			, System.String message
			, System.DateTime eventTime
			)
        {
            InsertEntity(new MSBuildLogsExtended.DataSourceEntities.BuildLog(
				id
				, buildId
				, buildEventCodeId
				, message
				, eventTime));
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="buildId">property value of System.Int64</param>
        /// <param name="buildEventCodeId">property value of System.Int32</param>
        /// <param name="message">property value of System.String</param>
        /// <param name="eventTime">property value of System.DateTime</param>
        public static void Update(
			System.Int64 id
			, System.Int64 buildId
			, System.Int32 buildEventCodeId
			, System.String message
			, System.DateTime eventTime			)
        {
            UpdateEntity(new MSBuildLogsExtended.DataSourceEntities.BuildLog(
				id
				, buildId
				, buildEventCodeId
				, message
				, eventTime));
        }


		/// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="buildId">property value of System.Int64</param>
        /// <param name="buildEventCodeId">property value of System.Int32</param>
        /// <param name="message">property value of System.String</param>
        /// <param name="eventTime">property value of System.DateTime</param>
        public static void Delete(
			System.Int64 id
			, System.Int64 buildId
			, System.Int32 buildEventCodeId
			, System.String message
			, System.DateTime eventTime
			)
        {
            DeleteEntity(new MSBuildLogsExtended.DataSourceEntities.BuildLog(
				id
				, buildId
				, buildEventCodeId
				, message
				, eventTime));
        }

		/// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteByIdentifier(
			System.Int64 id
			)
        {
            return DeleteByIdentifierEntity(new MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier(
				id));
        }

        #endregion insert, update and delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog BatchUpdate(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchUpdate(_Request);
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog BatchInsert(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchInsert(_Request);
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog BatchDelete(MSBuildLogsExtended.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchDelete(_Request);
        }

        #endregion batch insert, update and delete in an entity collection
		


        #region Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfCommon(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfEntityOfCommon(
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
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfEntityOfCommon(
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
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
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
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfDefaultOfCommon(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfDefaultOfCommon(
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
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultOfCommon(
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
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
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
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfAll(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(

				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfNameValuePairOfAll(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(

				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfRssItemOfAll(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
);

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(

				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfByFKOnly(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfNameValuePairOfByFKOnly(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
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
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfRssItemOfByFKOnly(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
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
        public static Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfDefaultOfByFKOnly(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfDefaultGroupedDataViewOfByFKOnly(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("BuildId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfByIdentifier(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfDefaultOfByIdentifier(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetMessageOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfKeyInformationOfByIdentifier(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if NETFX_CORE
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("BusinessLogicLayerEntityStaticBuildLog", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





    }
}

