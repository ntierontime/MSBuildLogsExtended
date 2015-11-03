using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{
    /// <summary>
    ///  inherit WcfService contract which will take advantage of .Net Wcf,
    ///  consume BusinessLogicLayerMemberShip
    ///  utilize LinqDataAccessLayer class 
    ///  provides Single/Batch Insert/Update/Delete
    ///  query methods based on BusinessLogicLayerRequestMessage, convert data access message to business logic layer response message
    ///  this BLL class targets at entity <see cref="MSBuildLogsExtended.BuildEventCode"/>
    /// </summary>
    public class BusinessLogicLayerEntityBuildEventCode
		: MSBuildLogsExtended.WcfContracts.IBuildEventCodeWcfService
    {
		#region logger of Log4Net

        /// <summary>
        /// logger of Log4Net
        /// </summary>
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion logger of Log4Net

		#region DALClassInstance && BusinessLogicLayerMemberShip

        /// <summary>
        /// Gets or sets the DAL class instance.
        /// </summary>
        /// <value>
        /// The DAL class instance.
        /// </value>
        MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildEventCode DALClassInstance { get; set; }

        /// <summary>
        /// Gets or sets the business logic layer member ship.
        /// </summary>
        /// <value>
        /// The business logic layer member ship.
        /// </value>
        public Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract BusinessLogicLayerMemberShip { get; set; }

		#endregion DALClassInstance && BusinessLogicLayerMemberShip

		#region constructors


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntityBuildEventCode"/> class.
        /// </summary>
        public BusinessLogicLayerEntityBuildEventCode()
            : this(new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        public BusinessLogicLayerEntityBuildEventCode(
			Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
            : this(businessLogicLayerContext.BusinessLogicLayerMemberShip)
        {
        }

		
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BusinessLogicLayerEntityBuildEventCode(
			Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
			MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract _DataAccessLayerFactoryContract = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract>();
            this.DALClassInstance = _DataAccessLayerFactoryContract.CreateDALInstanceOfBuildEventCode();
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="dalClassInstance">The dal class instance.</param>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BusinessLogicLayerEntityBuildEventCode(
            MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildEventCode dalClassInstance
            , Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            this.DALClassInstance = dalClassInstance;
            this.BusinessLogicLayerMemberShip = businessLogicLayerMemberShip;
        }

		#endregion constructors

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection,MSBuildLogsExtended.DataSourceEntities.BuildEventCode,MSBuildLogsExtended.DataSourceEntities.BuildEventCodeIdentifier> Members


        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode request)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
                _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Critieria.Count == 1)
            {
                log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.Insert(request.Critieria[0]);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
                log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            return _retval;
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode request)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Critieria.Count == 1)
            {
                log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.Update(request.Critieria[0]);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
                log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            return _retval;
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode request)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Critieria.Count == 1)
            {
                log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.Delete(request.Critieria[0]);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
                log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            return _retval;
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildEventCode id)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;

            if (id != null && id.Critieria != null)
            {
                log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.DeleteByIdentifier(id.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
                log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            return _retval;
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode request)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.BatchInsert(request.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
                log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode request)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.BatchDelete(request.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode request)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.BatchDelete(request.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }		

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection,MSBuildLogsExtended.DataSourceEntities.BuildEventCode,MSBuildLogsExtended.DataSourceEntities.BuildEventCodeIdentifier> Members

		#region Binary Columns



        #endregion Binary Columns

		#region DataQueryPerQuerySettingCollection



        #region Query Methods Of Entity of Common 

        /// <summary>
        /// Gets the count of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.EventCodeCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.DescriptionCommonOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.EventCodeCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.DescriptionCommonOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.EventCodeCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.DescriptionCommonOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuildEventCode _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.EventCodeCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon.DescriptionCommonOft
				, request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Entity of All 

        /// <summary>
        /// Gets the count of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuildEventCode _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfAll(
				request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

        /// <summary>
        /// Gets the count of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfNameValuePairOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfNameValuePairOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        /// <summary>
        /// Gets the collection of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfNameValuePairOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValueCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode.NameValuePair());
            }

            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.GetSingleOfNameValuePairOfAll(
				request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode.NameValuePair());
            }

            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

        /// <summary>
        /// Gets the count of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfRssItemOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfRssItemOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        /// <summary>
        /// Gets the collection of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfRssItemOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItemCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode.RssItem());
            }

            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.GetSingleOfRssItemOfAll(
				request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode.RssItem());
            }

            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildEventCode _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuildEventCode _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
			Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.BuildEventCode.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation, MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode.KeyInformation());
            }

            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.BuildEventCode.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.GetSingleOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier.IdByIdentifierOft
				, request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInBuildEventCode.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation, MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformation, MSBuildLogsExtended.DataSourceEntities.BuildEventCode.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderBuildEventCode.KeyInformation());
            }

            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier 




		#endregion DataQueryPerQuerySettingCollection

		#region GetAscendantAndDescendant



		#endregion GetAscendantAndDescendant




	}
}


