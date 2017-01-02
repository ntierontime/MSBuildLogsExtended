using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MSBuildLogsExtended.CommonBLLEntities
{

    
	/// <summary>
    /// BusinessLogicLayerRequestMessageUserDefined, with Key=Common
    /// </summary>
    public partial class BuildRequestMessageUserDefinedOfCommon
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildChainedQueryCriteriaCommon>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfCommon"/> class.
        /// </summary>
        public BuildRequestMessageUserDefinedOfCommon()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfCommon"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildRequestMessageUserDefinedOfCommon(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfCommon"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildRequestMessageUserDefinedOfCommon(
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
    public partial class BuildRequestMessageUserDefinedOfAll
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildChainedQueryCriteriaAll>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfAll"/> class.
        /// </summary>
        public BuildRequestMessageUserDefinedOfAll()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfAll"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildRequestMessageUserDefinedOfAll(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfAll"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildRequestMessageUserDefinedOfAll(
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
    public partial class BuildRequestMessageUserDefinedOfByFKOnly
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildChainedQueryCriteriaByFKOnly>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfByFKOnly"/> class.
        /// </summary>
        public BuildRequestMessageUserDefinedOfByFKOnly()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfByFKOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildRequestMessageUserDefinedOfByFKOnly(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfByFKOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildRequestMessageUserDefinedOfByFKOnly(
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
    public partial class BuildRequestMessageUserDefinedOfByIdentifier
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildChainedQueryCriteriaByIdentifier>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfByIdentifier"/> class.
        /// </summary>
        public BuildRequestMessageUserDefinedOfByIdentifier()
			: base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfByIdentifier"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
		public BuildRequestMessageUserDefinedOfByIdentifier(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedOfByIdentifier"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildRequestMessageUserDefinedOfByIdentifier(
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




    #region EntityUpdateActionSetting - UpdateNameOnly
		
	/// <summary>
    /// BuildRequestMessageUserDefinedUpdateNameOnly, with ActionName:UpdateNameOnly;DataViewKey:UpdateNameRequest;PropertyList:Name;Description:;
    /// </summary>
    public partial class BuildRequestMessageUserDefinedUpdateNameOnly
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.Build.UpdateNameRequest>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedUpdateNameOnly"/> class.
        /// </summary>
        public BuildRequestMessageUserDefinedUpdateNameOnly()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageUserDefinedUpdateNameOnly"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BuildRequestMessageUserDefinedUpdateNameOnly(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID)
            : base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        #endregion constructors
    }
	
	#endregion EntityUpdateActionSetting - UpdateNameOnly



}