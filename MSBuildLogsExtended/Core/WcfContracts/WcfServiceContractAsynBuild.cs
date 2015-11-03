using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfContracts
{
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuild")]
    public interface WcfServiceContractAsynBuild
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection,MSBuildLogsExtended.DataSourceEntities.Build,MSBuildLogsExtended.DataSourceEntities.BuildIdentifier> Members

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntityResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntityResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuild id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntityResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntityResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsertResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDeleteResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdateResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntityResponse")]
        System.IAsyncResult BeginDeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndDeleteEntity(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntityResponse")]
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuild id, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndDeleteByIdentifierEntity(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntityResponse")]
        System.IAsyncResult BeginInsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndInsertEntity(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntityResponse")]
        System.IAsyncResult BeginUpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndUpdateEntity(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsertResponse")]
        System.IAsyncResult BeginBatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndBatchInsert(System.IAsyncResult result);

        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDeleteResponse")]
        System.IAsyncResult BeginBatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild inpu, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndBatchDelete(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdateResponse")]
        System.IAsyncResult BeginBatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndBatchUpdate(System.IAsyncResult result);

        #endregion





        #region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommonResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommonResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommonResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommonResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommonResponse")]
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommonResponse")]
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommonResponse")]
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommonResponse")]
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Default of Common 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommonResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommonResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommonResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetCollectionOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommonResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetSingleOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommonResponse")]
        System.IAsyncResult BeginGetCountOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfCommon(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommonResponse")]
        System.IAsyncResult BeginExistsOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfCommon(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommonResponse")]
        System.IAsyncResult BeginGetCollectionOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetCollectionOfDefaultOfCommon(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommonResponse")]
        System.IAsyncResult BeginGetSingleOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetSingleOfDefaultOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Default of Common 




        #region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAllResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAllResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAllResponse")]
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAllResponse")]
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAllResponse")]
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAllResponse")]
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfAll(System.IAsyncResult result);

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAllResponse")]
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAllResponse")]
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAllResponse")]
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAllResponse")]
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAllResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAllResponse")]
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAllResponse")]
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAllResponse")]
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAllResponse")]
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByFKOnly 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnlyResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnlyResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCountOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByFKOnly(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnlyResponse")]
        System.IAsyncResult BeginExistsOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCollectionOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetSingleOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByFKOnly 




        #region Query Methods Of NameValuePair of ByFKOnly 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCountOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfByFKOnly(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnlyResponse")]
        System.IAsyncResult BeginExistsOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetSingleOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of ByFKOnly 




        #region Query Methods Of RssItem of ByFKOnly 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCountOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfByFKOnly(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnlyResponse")]
        System.IAsyncResult BeginExistsOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCollectionOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetSingleOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of ByFKOnly 




        #region Query Methods Of Default of ByFKOnly 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnlyResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnlyResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCountOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByFKOnly(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnlyResponse")]
        System.IAsyncResult BeginExistsOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCollectionOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetCollectionOfDefaultOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetSingleOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetSingleOfDefaultOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByFKOnly 




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCountOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        System.IAsyncResult BeginExistsOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
        System.IAsyncResult BeginGetSingleOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView EndGetSingleOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




        #region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifierResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifierResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifierResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifierResponse")]
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifierResponse")]
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifierResponse")]
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of Default of ByIdentifier 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifierResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifierResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifierResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifierResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifierResponse")]
        System.IAsyncResult BeginGetCountOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByIdentifier(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifierResponse")]
        System.IAsyncResult BeginExistsOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByIdentifier(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifierResponse")]
        System.IAsyncResult BeginGetCollectionOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetCollectionOfDefaultOfByIdentifier(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifierResponse")]
        System.IAsyncResult BeginGetSingleOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetSingleOfDefaultOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);
		
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#endif

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);
		
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
        System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}