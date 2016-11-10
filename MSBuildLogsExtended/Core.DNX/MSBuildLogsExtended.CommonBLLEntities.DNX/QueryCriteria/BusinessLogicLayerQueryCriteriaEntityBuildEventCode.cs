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
    public class BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of EventCode</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Description</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon(
			QuerySystemStringContainsCriteria eventCodeCommonOft
			, QuerySystemStringContainsCriteria descriptionCommonOft
			)
		{
			this.EventCodeCommonOft = eventCodeCommonOft;
			this.DescriptionCommonOft = descriptionCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon"/> class.
        /// </summary>
        /// <param name="isToCompareEventCodeCommonOft">will compare/filter EventCodeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedEventCodeCommonOft">value to compare/filter with EventCodeCommonOft property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOft">will compare/filter DescriptionCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOft">value to compare/filter with DescriptionCommonOft property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon(
			bool isToCompareEventCodeCommonOft, System.String valueToBeContainedEventCodeCommonOft
			, bool isToCompareDescriptionCommonOft, System.String valueToBeContainedDescriptionCommonOft
			)
			: this(
				new QuerySystemStringContainsCriteria(isToCompareEventCodeCommonOft, valueToBeContainedEventCodeCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOft, valueToBeContainedDescriptionCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of EventCode, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria EventCodeCommonOft { get; set; }

        /// <summary>
        /// criteria of Description, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier(
			QuerySystemInt32EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier(
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