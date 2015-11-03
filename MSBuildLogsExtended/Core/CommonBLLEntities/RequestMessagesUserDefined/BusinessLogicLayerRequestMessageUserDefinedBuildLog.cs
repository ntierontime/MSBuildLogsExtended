using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MSBuildLogsExtended.CommonBLLEntities
{

    
	/// <summary>
    /// BusinessLogicLayerRequestMessageUserDefined, with Key=Common
    /// </summary>
    public class BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfCommon(
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
    public class BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfAll(
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
    public class BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByFKOnly(
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
    public class BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageUserDefinedBuildLogOfByIdentifier(
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