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
    public partial class BuildLogQueryCriteriaCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaCommon"/> class.
        /// </summary>
		public BuildLogQueryCriteriaCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of EventTime</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Message</param>
		public BuildLogQueryCriteriaCommon(
			QuerySystemInt64EqualsCriteria idCommonOfBuild_1
			, QuerySystemInt32EqualsCriteria idCommonOfSolution_1
			, QuerySystemInt32EqualsCriteria idCommonOfBuildEventCode_1
			, QuerySystemDateTimeRangeCriteria eventTimeCommonOft
			, QuerySystemStringContainsCriteria messageCommonOft
			)
		{
			this.IdCommonOfBuild_1 = idCommonOfBuild_1;
			this.IdCommonOfSolution_1 = idCommonOfSolution_1;
			this.IdCommonOfBuildEventCode_1 = idCommonOfBuildEventCode_1;
			this.EventTimeCommonOft = eventTimeCommonOft;
			this.MessageCommonOft = messageCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1">will compare/filter IdCommonOfBuild_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1">value to compare/filter with IdCommonOfBuild_1 property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1">will compare/filter IdCommonOfSolution_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1">value to compare/filter with IdCommonOfSolution_1 property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1">will compare/filter IdCommonOfBuildEventCode_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1">value to compare/filter with IdCommonOfBuildEventCode_1 property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOft">will compare/filter EventTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOft">will compare/filter to lower bound of EventTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOft">will compare/filter to upper bound of EventTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOft">upper bound</param>
        /// <param name="isToCompareMessageCommonOft">will compare/filter MessageCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOft">value to compare/filter with MessageCommonOft property/field/column</param>
		public BuildLogQueryCriteriaCommon(
			bool isToCompareIdCommonOfBuild_1, System.Int64 valueToCompareIdCommonOfBuild_1
			, bool isToCompareIdCommonOfSolution_1, System.Int32 valueToCompareIdCommonOfSolution_1
			, bool isToCompareIdCommonOfBuildEventCode_1, System.Int32 valueToCompareIdCommonOfBuildEventCode_1
			, bool isToCompareEventTimeCommonOft, bool isToCompareLowerBoundEventTimeCommonOft, System.DateTime lowerBoundEventTimeCommonOft, bool isToCompareUpperBoundEventTimeCommonOft, System.DateTime upperBoundEventTimeCommonOft
			, bool isToCompareMessageCommonOft, System.String valueToBeContainedMessageCommonOft
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_1, valueToCompareIdCommonOfBuild_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1, valueToCompareIdCommonOfSolution_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_1, valueToCompareIdCommonOfBuildEventCode_1)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOft, isToCompareLowerBoundEventTimeCommonOft, lowerBoundEventTimeCommonOft, isToCompareUpperBoundEventTimeCommonOft, upperBoundEventTimeCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOft, valueToBeContainedMessageCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfBuild_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfBuildEventCode_1 { get; set; }

        /// <summary>
        /// criteria of EventTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria EventTimeCommonOft { get; set; }

        /// <summary>
        /// criteria of Message, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria MessageCommonOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class BuildLogQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaAll"/> class.
        /// </summary>
		public BuildLogQueryCriteriaAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildLogQueryCriteriaByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByFKOnly"/> class.
        /// </summary>
		public BuildLogQueryCriteriaByFKOnly()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
		public BuildLogQueryCriteriaByFKOnly(
			QuerySystemInt64EqualsCriteria idByFKOnlyOfBuild_1
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfBuildEventCode_1
			)
		{
			this.IdByFKOnlyOfBuild_1 = idByFKOnlyOfBuild_1;
			this.IdByFKOnlyOfSolution_1 = idByFKOnlyOfSolution_1;
			this.IdByFKOnlyOfBuildEventCode_1 = idByFKOnlyOfBuildEventCode_1;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1">will compare/filter IdByFKOnlyOfBuild_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1">value to compare/filter with IdByFKOnlyOfBuild_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1">will compare/filter IdByFKOnlyOfSolution_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1">value to compare/filter with IdByFKOnlyOfSolution_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1">will compare/filter IdByFKOnlyOfBuildEventCode_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1">value to compare/filter with IdByFKOnlyOfBuildEventCode_1 property/field/column</param>
		public BuildLogQueryCriteriaByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1, System.Int64 valueToCompareIdByFKOnlyOfBuild_1
			, bool isToCompareIdByFKOnlyOfSolution_1, System.Int32 valueToCompareIdByFKOnlyOfSolution_1
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_1, valueToCompareIdByFKOnlyOfBuild_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1, valueToCompareIdByFKOnlyOfSolution_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_1, valueToCompareIdByFKOnlyOfBuildEventCode_1)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfBuild_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfBuildEventCode_1 { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildLogQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public BuildLogQueryCriteriaByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
		public BuildLogQueryCriteriaByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public BuildLogQueryCriteriaByIdentifier(
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