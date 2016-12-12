using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynSolution")]
#endif
    public interface WcfServiceContractAsynSolution
    {

#region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection,MSBuildLogsExtended.DataSourceEntities.Solution,MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier> Members

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/InsertEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/UpdateEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchInsertResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input);

       
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchDeleteResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchUpdateResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution id, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/InsertEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/UpdateEntity",
            ReplyAction = "http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchInsert", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndBatchInsert(System.IAsyncResult result);

        
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchDelete", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution inpu, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchUpdate", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution input, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndBatchUpdate(System.IAsyncResult result);

#endregion





#region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndGetSingleOfEntityOfAll(System.IAsyncResult result);

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

#endregion Query Methods Of NameValuePair of All 




#region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfRssItemOfAllResponse")]
#endif
       Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

#endregion Query Methods Of RssItem of All 




#region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of Entity of ByIdentifier 




#region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
       [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.nTierSketchUp.com/MSBuildLogsExtended/WcfContracts/ISolutionWcfService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
       System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}