using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode")]
#endif
    public interface WcfServiceContractAsynBuildEventCode
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection,MSBuildLogsExtended.DataSourceEntities.BuildEventCode,MSBuildLogsExtended.DataSourceEntities.BuildEventCodeIdentifier> Members

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildEventCode id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/InsertEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/UpdateEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchInsertResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchDeleteResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchUpdateResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildEventCode id, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode inpu, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndBatchUpdate(System.IAsyncResult result);

        #endregion





        #region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndGetSingleOfEntityOfAll(System.IAsyncResult result);

#endregion Query Methods Of Entity of All 




#region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

#endregion Query Methods Of NameValuePair of All 




#region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

#endregion Query Methods Of RssItem of All 




#region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of Entity of ByIdentifier 




#region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildEventCodeWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}