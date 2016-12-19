using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildLogsExtended.WcfClientBLL
{
    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// *4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// 5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public interface WcfClientEntityBuildEventCodeChannel : MSBuildLogsExtended.WcfContracts.IBuildEventCodeService, System.ServiceModel.IClientChannel {
    }

    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// 4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// *5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public partial class WcfClientEntityBuildEventCode : System.ServiceModel.ClientBase<MSBuildLogsExtended.WcfContracts.IBuildEventCodeService>, MSBuildLogsExtended.WcfContracts.IBuildEventCodeService {

		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        public WcfClientEntityBuildEventCode() {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public WcfClientEntityBuildEventCode(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildEventCode(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
		public WcfClientEntityBuildEventCode(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildEventCode(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

		#endregion constructors
        
        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection,MSBuildLogsExtended.DataSourceEntities.BuildEventCode,MSBuildLogsExtended.DataSourceEntities.BuildEventCodeIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.UpdateEntity(request);
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.DeleteEntity(request);
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.DeleteByIdentifierEntity(id);
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.BatchInsert(request);
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.BatchUpdate(request);
        }		

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection,MSBuildLogsExtended.DataSourceEntities.BuildEventCode,MSBuildLogsExtended.DataSourceEntities.BuildEventCodeIdentifier> Members





        #region Query Methods Of Entity of Common 

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCountOfEntityOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.ExistsOfEntityOfCommon(request);
		}

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetSingleOfEntityOfCommon(request);
		}

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Entity of All 

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfEntityOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfEntityOfAll(request);
		}

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfEntityOfAll(request);
		}

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfNameValuePairOfAll(request);
		}

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfNameValuePairOfAll(request);
		}

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfRssItemOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfRssItemOfAll(request);
		}

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfRssItemOfAll(request);
		}

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfEntityOfByIdentifier(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfEntityOfByIdentifier(request);
		}

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfKeyInformationOfByIdentifier(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfKeyInformationOfByIdentifier(request);
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier 







		
#if WINDOWS_PHONE
        protected override MSBuildLogsExtended.WcfContracts.IBuildEventCodeService CreateChannel()
        {
            throw new NotImplementedException();
        }
#else
#endif
	}
}