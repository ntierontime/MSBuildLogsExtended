using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BuiltIn BusinessLogicLayerRequestMessage for entity MSBuildLogsExtended.Build
    /// </summary>
    public partial class BuildRequestMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection>
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageBuiltIn"/> class.
        /// </summary>
        public BuildRequestMessageBuiltIn()
			: base()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageBuiltIn"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>        
		/// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BuildRequestMessageBuiltIn(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageBuiltIn"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildRequestMessageBuiltIn(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			, int currentIndex
            , int pageSize
			, string queryOrderByExpression)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression)
        {
        }

        #endregion constructors
    }

    /// <summary>
    /// BuiltIn BusinessLogicLayerRequestMessage for entity MSBuildLogsExtended.DataSourceEntities.BuildIdentifier
    /// </summary>
    public partial class BuildRequestMessageBuiltInOfIdentifier
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildIdentifier>
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageBuiltInOfIdentifier"/> class.
        /// </summary>
        public BuildRequestMessageBuiltInOfIdentifier()
			: base()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageBuiltIn"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>        
		/// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BuildRequestMessageBuiltInOfIdentifier(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRequestMessageBuiltIn"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BuildRequestMessageBuiltInOfIdentifier(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			, int currentIndex
            , int pageSize
			, string queryOrderByExpression)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression)
        {
        }

        #endregion constructors
    }
}