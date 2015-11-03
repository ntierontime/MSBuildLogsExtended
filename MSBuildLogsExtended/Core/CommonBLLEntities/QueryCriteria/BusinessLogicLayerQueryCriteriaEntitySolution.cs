using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.EntityContracts;
using Framework;

namespace MSBuildLogsExtended.CommonBLLEntities
{

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Common
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntitySolutionCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionCommon"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntitySolutionCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of ExternalParentId</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Description</param>
		public BusinessLogicLayerQueryCriteriaEntitySolutionCommon(
			QuerySystemStringContainsCriteria externalParentIdCommonOft
			, QuerySystemStringContainsCriteria nameCommonOft
			, QuerySystemStringContainsCriteria descriptionCommonOft
			)
		{
			this.ExternalParentIdCommonOft = externalParentIdCommonOft;
			this.NameCommonOft = nameCommonOft;
			this.DescriptionCommonOft = descriptionCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionCommon"/> class.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOft">will compare/filter ExternalParentIdCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOft">value to compare/filter with ExternalParentIdCommonOft property/field/column</param>
        /// <param name="isToCompareNameCommonOft">will compare/filter NameCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOft">value to compare/filter with NameCommonOft property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOft">will compare/filter DescriptionCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOft">value to compare/filter with DescriptionCommonOft property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntitySolutionCommon(
			bool isToCompareExternalParentIdCommonOft, System.String valueToBeContainedExternalParentIdCommonOft
			, bool isToCompareNameCommonOft, System.String valueToBeContainedNameCommonOft
			, bool isToCompareDescriptionCommonOft, System.String valueToBeContainedDescriptionCommonOft
			)
			: this(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOft, valueToBeContainedExternalParentIdCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOft, valueToBeContainedNameCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOft, valueToBeContainedDescriptionCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of ExternalParentId, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria ExternalParentIdCommonOft { get; set; }

        /// <summary>
        /// criteria of Name, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; }

        /// <summary>
        /// criteria of Description, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntitySolutionAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionAll"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntitySolutionAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
		public BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier(
			QuerySystemInt32EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier(
			bool isToCompareIdByIdentifierOft, System.Int32 valueToCompareIdByIdentifierOft
			)
			: this(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOft, valueToCompareIdByIdentifierOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByIdentifierOft { get; set; }

		#endregion Propertyies
	}


}