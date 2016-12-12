using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuild")]
#endif
    public interface WcfServiceContractAsynBuild
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection,MSBuildLogsExtended.DataSourceEntities.Build,MSBuildLogsExtended.DataSourceEntities.BuildIdentifier> Members

#if SILVERLIGHT
#else
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuild id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsertResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDeleteResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdateResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuild id, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndBatchInsert(System.IAsyncResult result);


#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild inpu, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuild input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndBatchUpdate(System.IAsyncResult result);

        #endregion





        #region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Default of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetCollectionOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetSingleOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetCollectionOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetSingleOfDefaultOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Default of Common 




        #region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfAll(System.IAsyncResult result);

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByFKOnly 




        #region Query Methods Of NameValuePair of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of ByFKOnly 




        #region Query Methods Of RssItem of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of ByFKOnly 




        #region Query Methods Of Default of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetCollectionOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetSingleOfDefaultOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByFKOnly 




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultGroupedDataViewOfByFKOnly(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.DefaultGroupedDataView EndGetSingleOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




        #region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of Default of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetCollectionOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.Default EndGetSingleOfDefaultOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/IBuildWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuild.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}