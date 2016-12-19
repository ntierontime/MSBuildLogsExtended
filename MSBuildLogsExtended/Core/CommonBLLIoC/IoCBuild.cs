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
    public static class IoCBuild
    {
        #region insert, update and delete in request message

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn InsertRequest(
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.InsertEntity(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateRequest(
			MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.UpdateEntity(_Request);
        }

        /// <summary>
        /// Deletes By Identifier an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierRequest(
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.DeleteByIdentifierEntity(_Request);
        }

        /// <summary>
        /// Deletes an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteRequest(
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.DeleteEntity(_Request);
        }

        #endregion insert, update and delete in request message
		
        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(
            MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request =new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _Request.Critieria.Add(input);
            return InsertRequest(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(
            MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _Request.Critieria.Add(input);
            return UpdateRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildLogsExtended.DataSourceEntities.BuildIdentifier identifier)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = identifier;
            return DeleteByIdentifierRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(
            MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _Request.Critieria.Add(input);
            return DeleteRequest(_Request);
        }

        #endregion insert, update and delete in an entity

        #region insert, update and delete using .Net value types

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="solutionId">property value of System.Int32</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        /// <param name="buildStartTime">property value of System.DateTime</param>
        public static void Insert(
			System.Int64 id
			, System.Int32 solutionId
			, System.String name
			, System.String description
			, System.DateTime buildStartTime
			)
        {
            InsertEntity(new MSBuildLogsExtended.DataSourceEntities.Build(
				id
				, solutionId
				, name
				, description
				, buildStartTime));
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="solutionId">property value of System.Int32</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        /// <param name="buildStartTime">property value of System.DateTime</param>
        public static void Update(
			System.Int64 id
			, System.Int32 solutionId
			, System.String name
			, System.String description
			, System.DateTime buildStartTime			)
        {
            UpdateEntity(new MSBuildLogsExtended.DataSourceEntities.Build(
				id
				, solutionId
				, name
				, description
				, buildStartTime));
        }


		/// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="solutionId">property value of System.Int32</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        /// <param name="buildStartTime">property value of System.DateTime</param>
        public static void Delete(
			System.Int64 id
			, System.Int32 solutionId
			, System.String name
			, System.String description
			, System.DateTime buildStartTime
			)
        {
            DeleteEntity(new MSBuildLogsExtended.DataSourceEntities.Build(
				id
				, solutionId
				, name
				, description
				, buildStartTime));
        }

		/// <summary>
        /// delete an entity of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifier(
			System.Int64 id
			)
        {
            return DeleteByIdentifierEntity(new MSBuildLogsExtended.DataSourceEntities.BuildIdentifier(
				id));
        }

        #endregion insert, update and delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn BatchUpdate(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchUpdate(_Request);
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn BatchInsert(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchInsert(_Request);
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildLogsExtended.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn BatchDelete(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int GetPageCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
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
        public static int GetCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
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
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaCommon(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfAll(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(

				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(

				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaAll(

				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfNameValuePairOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfRssItemOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("SolutionId", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
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
        public static bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
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
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.BuildCollection GetSingleOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfDefaultOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfUpdateNameRequestOfByIdentifier for GetPageNumberListOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
		            //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier for GetPageCountOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
	            //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfUpdateNameRequestOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetSingleOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfUpdateNameRequestOfByIdentifier for GetPageNumberListOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
		            //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfUpdateNameRequestOfByIdentifier for GetPageCountOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
	            //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequestCollection GetSingleOfUpdateNameRequestOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfUpdateNameRequestOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetSingleOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
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

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
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
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
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
	            //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation"/></returns>
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //Framework.Web.WebFormApplicationExceptionHandler.Process("IoCBuild", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





        #region EntityUpdateActionSetting - UpdateNameOnly
		
        public static MSBuildLogsExtended.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request)
        {
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildLogsExtended.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.UpdateNameOnly(request);
        }

		#endregion EntityUpdateActionSetting - UpdateNameOnly



    }
}

