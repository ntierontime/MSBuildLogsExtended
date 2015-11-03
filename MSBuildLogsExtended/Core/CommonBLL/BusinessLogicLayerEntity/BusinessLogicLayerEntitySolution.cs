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
    ///  this BLL class targets at entity <see cref="MSBuildLogsExtended.Solution"/>
    /// </summary>
    public class BusinessLogicLayerEntitySolution
		: MSBuildLogsExtended.WcfContracts.ISolutionWcfService
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
        MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractSolution DALClassInstance { get; set; }

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
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntitySolution"/> class.
        /// </summary>
        public BusinessLogicLayerEntitySolution()
            : this(new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntitySolution"/> class.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        public BusinessLogicLayerEntitySolution(
			Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
            : this(businessLogicLayerContext.BusinessLogicLayerMemberShip)
        {
        }

		
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntitySolution"/> class.
        /// </summary>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BusinessLogicLayerEntitySolution(
			Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
			MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract _DataAccessLayerFactoryContract = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract>();
            this.DALClassInstance = _DataAccessLayerFactoryContract.CreateDALInstanceOfSolution();
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerEntitySolution"/> class.
        /// </summary>
        /// <param name="dalClassInstance">The dal class instance.</param>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BusinessLogicLayerEntitySolution(
            MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractSolution dalClassInstance
            , Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            this.DALClassInstance = dalClassInstance;
            this.BusinessLogicLayerMemberShip = businessLogicLayerMemberShip;
        }

		#endregion constructors

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection,MSBuildLogsExtended.DataSourceEntities.Solution,MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier> Members


        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution InsertEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution request)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
                _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Critieria.Count == 1)
            {
                log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.Insert(request.Critieria[0]);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
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
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution UpdateEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution request)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Critieria.Count == 1)
            {
                log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.Update(request.Critieria[0]);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
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
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution DeleteEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution request)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Critieria.Count == 1)
            {
                log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.Delete(request.Critieria[0]);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
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
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution DeleteByIdentifierEntity(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution id)
        {
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;

            if (id != null && id.Critieria != null)
            {
                log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.DeleteByIdentifier(id.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
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
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution BatchInsert(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution request)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.BatchInsert(request.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
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
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution BatchDelete(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution request)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.BatchDelete(request.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
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
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution BatchUpdate(MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInSolution request)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.BatchDelete(request.Critieria);

                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }		

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection,MSBuildLogsExtended.DataSourceEntities.Solution,MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier> Members

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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.ExternalParentIdCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.NameCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.DescriptionCommonOft
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.ExternalParentIdCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.NameCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.DescriptionCommonOft
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
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetCollectionOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.ExternalParentIdCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.NameCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.DescriptionCommonOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetSingleOfEntityOfCommon(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfCommon request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfCommon(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.ExternalParentIdCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.NameCommonOft
				, request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionCommon.DescriptionCommonOft
				, request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetCollectionOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfAll(
				request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetSingleOfEntityOfAll(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfAll(
				request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution.NameValuePair());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution.NameValuePair());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution.RssItem());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfAll request)
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
				//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution.RssItem());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
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
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetCollectionOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution GetSingleOfEntityOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
				, request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution());
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
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
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
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
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation if any</returns>
		public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
				, request.QueryPagingSetting.CurrentIndex
				, request.QueryPagingSetting.PageSize
				, request.QueryOrderBySettingCollection
				);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

			//Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation, MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution.KeyInformation());
            }

            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation if any</returns>
        public MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedSolutionOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.GetSingleOfKeyInformationOfByIdentifier(
				request.Critieria.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier.IdByIdentifierOft
				, request.QueryOrderBySettingCollection);
            MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation _retval = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerResponseMessageBuiltInSolution.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation, MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
				Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation, MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildLogsExtended.CommonBLL.DataStreamServiceProviderSolution.KeyInformation());
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


