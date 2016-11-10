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
    public class BusinessLogicLayerQueryCriteriaEntityBuildCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildCommon"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Description</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of BuildStartTime</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildCommon(
			QuerySystemInt32EqualsCriteria idCommonOfSolution_S1_1
			, QuerySystemStringContainsCriteria nameCommonOft
			, QuerySystemStringContainsCriteria descriptionCommonOft
			, QuerySystemDateTimeRangeCriteria buildStartTimeCommonOft
			)
		{
			this.IdCommonOfSolution_S1_1 = idCommonOfSolution_S1_1;
			this.NameCommonOft = nameCommonOft;
			this.DescriptionCommonOft = descriptionCommonOft;
			this.BuildStartTimeCommonOft = buildStartTimeCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_S1_1">will compare/filter IdCommonOfSolution_S1_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1">value to compare/filter with IdCommonOfSolution_S1_1 property/field/column</param>
        /// <param name="isToCompareNameCommonOft">will compare/filter NameCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOft">value to compare/filter with NameCommonOft property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOft">will compare/filter DescriptionCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOft">value to compare/filter with DescriptionCommonOft property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOft">will compare/filter BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOft">will compare/filter to lower bound of BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOft">will compare/filter to upper bound of BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOft">upper bound</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildCommon(
			bool isToCompareIdCommonOfSolution_S1_1, System.Int32 valueToCompareIdCommonOfSolution_S1_1
			, bool isToCompareNameCommonOft, System.String valueToBeContainedNameCommonOft
			, bool isToCompareDescriptionCommonOft, System.String valueToBeContainedDescriptionCommonOft
			, bool isToCompareBuildStartTimeCommonOft, bool isToCompareLowerBoundBuildStartTimeCommonOft, System.DateTime lowerBoundBuildStartTimeCommonOft, bool isToCompareUpperBoundBuildStartTimeCommonOft, System.DateTime upperBoundBuildStartTimeCommonOft
			)
			: this(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1, valueToCompareIdCommonOfSolution_S1_1)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOft, valueToBeContainedNameCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOft, valueToBeContainedDescriptionCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOft, isToCompareLowerBoundBuildStartTimeCommonOft, lowerBoundBuildStartTimeCommonOft, isToCompareUpperBoundBuildStartTimeCommonOft, upperBoundBuildStartTimeCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_S1_1 { get; set; }

        /// <summary>
        /// criteria of Name, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; }

        /// <summary>
        /// criteria of Description, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; }

        /// <summary>
        /// criteria of BuildStartTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria BuildStartTimeCommonOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildAll"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly(
			QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_S1_1
			)
		{
			this.IdByFKOnlyOfSolution_S1_1 = idByFKOnlyOfSolution_S1_1;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1">will compare/filter IdByFKOnlyOfSolution_S1_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1">value to compare/filter with IdByFKOnlyOfSolution_S1_1 property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_S1_1, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1
			)
			: this(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1, valueToCompareIdByFKOnlyOfSolution_S1_1)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_S1_1 { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier(
			bool isToCompareIdByIdentifierOft, System.Int64 valueToCompareIdByIdentifierOft
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOft, valueToCompareIdByIdentifierOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByIdentifierOft { get; set; }

		#endregion Propertyies
	}


}