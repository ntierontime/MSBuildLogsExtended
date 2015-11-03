using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BuiltIn BusinessLogicLayerRequestMessage for entity MSBuildLogsExtended.BuildLog
    /// </summary>
    public class BusinessLogicLayerRequestMessageBuiltInBuildLog
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildLogCollection>
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInBuildLog"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageBuiltInBuildLog()
			: base()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInBuildLog"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>        
		/// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BusinessLogicLayerRequestMessageBuiltInBuildLog(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInBuildLog"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageBuiltInBuildLog(
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
    /// BuiltIn BusinessLogicLayerRequestMessage for entity MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier
    /// </summary>
    public class BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier>
    {
#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog()
			: base()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInBuildLog"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>        
		/// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInBuildLog"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageBuiltInOfIdentifierBuildLog(
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