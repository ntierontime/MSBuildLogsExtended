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
    public partial class BuildQueryCriteriaCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaCommon"/> class.
        /// </summary>
		public BuildQueryCriteriaCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of BuildStartTime</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Description</param>
		public BuildQueryCriteriaCommon(
			QuerySystemInt32EqualsCriteria idCommonOfSolution_1
			, QuerySystemDateTimeRangeCriteria buildStartTimeCommonOft
			, QuerySystemStringContainsCriteria nameCommonOft
			, QuerySystemStringContainsCriteria descriptionCommonOft
			)
		{
			this.IdCommonOfSolution_1 = idCommonOfSolution_1;
			this.BuildStartTimeCommonOft = buildStartTimeCommonOft;
			this.NameCommonOft = nameCommonOft;
			this.DescriptionCommonOft = descriptionCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1">will compare/filter IdCommonOfSolution_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1">value to compare/filter with IdCommonOfSolution_1 property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOft">will compare/filter BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOft">will compare/filter to lower bound of BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOft">will compare/filter to upper bound of BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOft">upper bound</param>
        /// <param name="isToCompareNameCommonOft">will compare/filter NameCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOft">value to compare/filter with NameCommonOft property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOft">will compare/filter DescriptionCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOft">value to compare/filter with DescriptionCommonOft property/field/column</param>
		public BuildQueryCriteriaCommon(
			bool isToCompareIdCommonOfSolution_1, System.Int32 valueToCompareIdCommonOfSolution_1
			, bool isToCompareBuildStartTimeCommonOft, bool isToCompareLowerBoundBuildStartTimeCommonOft, System.DateTime lowerBoundBuildStartTimeCommonOft, bool isToCompareUpperBoundBuildStartTimeCommonOft, System.DateTime upperBoundBuildStartTimeCommonOft
			, bool isToCompareNameCommonOft, System.String valueToBeContainedNameCommonOft
			, bool isToCompareDescriptionCommonOft, System.String valueToBeContainedDescriptionCommonOft
			)
			: this(
				new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1, valueToCompareIdCommonOfSolution_1)
				, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOft, isToCompareLowerBoundBuildStartTimeCommonOft, lowerBoundBuildStartTimeCommonOft, isToCompareUpperBoundBuildStartTimeCommonOft, upperBoundBuildStartTimeCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOft, valueToBeContainedNameCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOft, valueToBeContainedDescriptionCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_1 { get; set; }

        /// <summary>
        /// criteria of BuildStartTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria BuildStartTimeCommonOft { get; set; }

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
    public partial class BuildQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaAll"/> class.
        /// </summary>
		public BuildQueryCriteriaAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildQueryCriteriaByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByFKOnly"/> class.
        /// </summary>
		public BuildQueryCriteriaByFKOnly()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
		public BuildQueryCriteriaByFKOnly(
			QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1
			)
		{
			this.IdByFKOnlyOfSolution_1 = idByFKOnlyOfSolution_1;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1">will compare/filter IdByFKOnlyOfSolution_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1">value to compare/filter with IdByFKOnlyOfSolution_1 property/field/column</param>
		public BuildQueryCriteriaByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1, System.Int32 valueToCompareIdByFKOnlyOfSolution_1
			)
			: this(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1, valueToCompareIdByFKOnlyOfSolution_1)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_1 { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public BuildQueryCriteriaByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
		public BuildQueryCriteriaByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public BuildQueryCriteriaByIdentifier(
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