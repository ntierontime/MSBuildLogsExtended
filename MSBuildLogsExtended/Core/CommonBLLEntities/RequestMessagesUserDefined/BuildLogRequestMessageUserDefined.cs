using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MSBuildLogsExtended.CommonBLLEntities
{

    
	/// <summary>
    /// BusinessLogicLayerRequestMessageUserDefined, with Key=Common
    /// </summary>
    public partial class BuildLogRequestMessageUserDefinedOfCommon
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildLogChainedQueryCriteriaCommon>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfCommon"/> class.
        /// </summary>
        public BuildLogRequestMessageUserDefinedOfCommon()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfCommon"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildLogRequestMessageUserDefinedOfCommon(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfCommon"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildLogRequestMessageUserDefinedOfCommon(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression)
        {
        }

        #endregion constructors
    }


    
	/// <summary>
    /// BusinessLogicLayerRequestMessageUserDefined, with Key=All
    /// </summary>
    public partial class BuildLogRequestMessageUserDefinedOfAll
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildLogChainedQueryCriteriaAll>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfAll"/> class.
        /// </summary>
        public BuildLogRequestMessageUserDefinedOfAll()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfAll"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildLogRequestMessageUserDefinedOfAll(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfAll"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildLogRequestMessageUserDefinedOfAll(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression)
        {
        }

        #endregion constructors
    }


    
	/// <summary>
    /// BusinessLogicLayerRequestMessageUserDefined, with Key=ByFKOnly
    /// </summary>
    public partial class BuildLogRequestMessageUserDefinedOfByFKOnly
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildLogChainedQueryCriteriaByFKOnly>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfByFKOnly"/> class.
        /// </summary>
        public BuildLogRequestMessageUserDefinedOfByFKOnly()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfByFKOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildLogRequestMessageUserDefinedOfByFKOnly(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfByFKOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildLogRequestMessageUserDefinedOfByFKOnly(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression)
        {
        }

        #endregion constructors
    }


    
	/// <summary>
    /// BusinessLogicLayerRequestMessageUserDefined, with Key=ByIdentifier
    /// </summary>
    public partial class BuildLogRequestMessageUserDefinedOfByIdentifier
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildLogChainedQueryCriteriaByIdentifier>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfByIdentifier"/> class.
        /// </summary>
        public BuildLogRequestMessageUserDefinedOfByIdentifier()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfByIdentifier"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildLogRequestMessageUserDefinedOfByIdentifier(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogRequestMessageUserDefinedOfByIdentifier"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildLogRequestMessageUserDefinedOfByIdentifier(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression)
        {
        }

        #endregion constructors
    }




}