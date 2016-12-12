using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildLog")]
#endif
    public interface WcfServiceContractAsynBuildLog
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildLogCollection,MSBuildLogsExtended.DataSourceEntities.BuildLog,MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier> Members

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/InsertEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/UpdateEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchInsertResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input);

        
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchDeleteResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchUpdateResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog id, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndBatchInsert(System.IAsyncResult result);


#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog inpu, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildLog input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndBatchUpdate(System.IAsyncResult result);

#endregion





#region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

#endregion Query Methods Of Entity of Common 




#region Query Methods Of Default of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetCollectionOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetSingleOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default EndGetCollectionOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default EndGetSingleOfDefaultOfCommon(System.IAsyncResult result);

#endregion Query Methods Of Default of Common 




#region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetSingleOfEntityOfAll(System.IAsyncResult result);

#endregion Query Methods Of Entity of All 




#region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

#endregion Query Methods Of NameValuePair of All 




#region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

#endregion Query Methods Of RssItem of All 




#region Query Methods Of Entity of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetCollectionOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetSingleOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetCollectionOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetSingleOfEntityOfByFKOnly(System.IAsyncResult result);

#endregion Query Methods Of Entity of ByFKOnly 




#region Query Methods Of NameValuePair of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#endregion Query Methods Of NameValuePair of ByFKOnly 




#region Query Methods Of RssItem of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfByFKOnly(System.IAsyncResult result);

#endregion Query Methods Of RssItem of ByFKOnly 




#region Query Methods Of Default of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default EndGetCollectionOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default EndGetSingleOfDefaultOfByFKOnly(System.IAsyncResult result);

#endregion Query Methods Of Default of ByFKOnly 




#region Query Methods Of DefaultGroupedDataView of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.DefaultGroupedDataView EndGetSingleOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




#region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of Entity of ByIdentifier 




#region Query Methods Of Default of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default EndGetCollectionOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.Default EndGetSingleOfDefaultOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of Default of ByIdentifier 




#region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildLogWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
       System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildLog.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}