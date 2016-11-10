using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLLEntities
{
    /// <summary>
    /// BuiltIn BusinessLogicLayerRequestMessage for entity MSBuildLogsExtended.Solution
    /// </summary>
    public class BusinessLogicLayerRequestMessageBuiltInSolution
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection>
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInSolution"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageBuiltInSolution()
			: base()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInSolution"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>        
		/// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BusinessLogicLayerRequestMessageBuiltInSolution(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInSolution"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageBuiltInSolution(
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
    /// BuiltIn BusinessLogicLayerRequestMessage for entity MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier
    /// </summary>
    public class BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution
        : Framework.CommonBLLEntities.BusinessLogicLayerRequestMessageBase<MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier>
    {
#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution"/> class.
        /// </summary>
        public BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution()
			: base()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInSolution"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>        
		/// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        public BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution(
            Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes businessLogicLayerRequestTypes
            , string businessLogicLayerRequestTypeKey
            , string businessLogicLayerRequestID
			)
			: base(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerRequestMessageBuiltInSolution"/> class.
        /// </summary>
        /// <param name="businessLogicLayerRequestTypes">The business logic layer request types.</param>
        /// <param name="businessLogicLayerRequestTypeKey">The business logic layer request type key.</param>
        /// <param name="businessLogicLayerRequestID">The business logic layer request ID.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public BusinessLogicLayerRequestMessageBuiltInOfIdentifierSolution(
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