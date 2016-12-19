using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildLogsExtended.WcfContracts.IBuildLogService")]
#endif
    public interface IBuildLogService
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildLogCollection,MSBuildLogsExtended.DataSourceEntities.BuildLog,MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier> Members

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/DeleteEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/InsertEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/UpdateEntityResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/BatchInsert", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/BatchInsertResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/BatchDelete", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/BatchDeleteResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/BatchUpdate", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/BatchUpdateResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

        #endregion





        #region Query Methods Of Entity of Common 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Default of Common 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

        #endregion Query Methods Of Default of Common 




        #region Query Methods Of Entity of All 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of Entity of ByFKOnly 




        #region Query Methods Of NameValuePair of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of NameValuePair of ByFKOnly 




        #region Query Methods Of RssItem of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of RssItem of ByFKOnly 




        #region Query Methods Of Default of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of Default of ByFKOnly 




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




        #region Query Methods Of Entity of ByIdentifier 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of Default of ByIdentifier 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of Default of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildLogsExtended/WcfContracts/IBuildLogService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildLogsExtended.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}

