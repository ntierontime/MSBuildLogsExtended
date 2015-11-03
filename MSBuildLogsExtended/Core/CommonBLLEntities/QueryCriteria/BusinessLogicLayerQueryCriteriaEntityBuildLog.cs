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
    public class BusinessLogicLayerQueryCriteriaEntityBuildLogCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogCommon"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Message</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of EventTime</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogCommon(
			QuerySystemInt64EqualsCriteria idCommonOfBuild_B1_1
			, QuerySystemInt32EqualsCriteria idCommonOfSolution_S1_1
			, QuerySystemInt32EqualsCriteria idCommonOfBuildEventCode_B2_1
			, QuerySystemStringContainsCriteria messageCommonOft
			, QuerySystemDateTimeRangeCriteria eventTimeCommonOft
			)
		{
			this.IdCommonOfBuild_B1_1 = idCommonOfBuild_B1_1;
			this.IdCommonOfSolution_S1_1 = idCommonOfSolution_S1_1;
			this.IdCommonOfBuildEventCode_B2_1 = idCommonOfBuildEventCode_B2_1;
			this.MessageCommonOft = messageCommonOft;
			this.EventTimeCommonOft = eventTimeCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1">will compare/filter IdCommonOfBuild_B1_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1">value to compare/filter with IdCommonOfBuild_B1_1 property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1">will compare/filter IdCommonOfSolution_S1_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1">value to compare/filter with IdCommonOfSolution_S1_1 property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1">will compare/filter IdCommonOfBuildEventCode_B2_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1">value to compare/filter with IdCommonOfBuildEventCode_B2_1 property/field/column</param>
        /// <param name="isToCompareMessageCommonOft">will compare/filter MessageCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOft">value to compare/filter with MessageCommonOft property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOft">will compare/filter EventTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOft">will compare/filter to lower bound of EventTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOft">will compare/filter to upper bound of EventTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOft">upper bound</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogCommon(
			bool isToCompareIdCommonOfBuild_B1_1, System.Int64 valueToCompareIdCommonOfBuild_B1_1
			, bool isToCompareIdCommonOfSolution_S1_1, System.Int32 valueToCompareIdCommonOfSolution_S1_1
			, bool isToCompareIdCommonOfBuildEventCode_B2_1, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1
			, bool isToCompareMessageCommonOft, System.String valueToBeContainedMessageCommonOft
			, bool isToCompareEventTimeCommonOft, bool isToCompareLowerBoundEventTimeCommonOft, System.DateTime lowerBoundEventTimeCommonOft, bool isToCompareUpperBoundEventTimeCommonOft, System.DateTime upperBoundEventTimeCommonOft
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1, valueToCompareIdCommonOfBuild_B1_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1, valueToCompareIdCommonOfSolution_S1_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1, valueToCompareIdCommonOfBuildEventCode_B2_1)
				, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOft, valueToBeContainedMessageCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOft, isToCompareLowerBoundEventTimeCommonOft, lowerBoundEventTimeCommonOft, isToCompareUpperBoundEventTimeCommonOft, upperBoundEventTimeCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfBuild_B1_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_S1_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfBuildEventCode_B2_1 { get; set; }

        /// <summary>
        /// criteria of Message, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria MessageCommonOft { get; set; }

        /// <summary>
        /// criteria of EventTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria EventTimeCommonOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildLogAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogAll"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly(
			QuerySystemInt64EqualsCriteria idByFKOnlyOfBuild_B1_1
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_S1_1
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfBuildEventCode_B2_1
			)
		{
			this.IdByFKOnlyOfBuild_B1_1 = idByFKOnlyOfBuild_B1_1;
			this.IdByFKOnlyOfSolution_S1_1 = idByFKOnlyOfSolution_S1_1;
			this.IdByFKOnlyOfBuildEventCode_B2_1 = idByFKOnlyOfBuildEventCode_B2_1;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1">will compare/filter IdByFKOnlyOfBuild_B1_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1">value to compare/filter with IdByFKOnlyOfBuild_B1_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1">will compare/filter IdByFKOnlyOfSolution_S1_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1">value to compare/filter with IdByFKOnlyOfSolution_S1_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1 property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1
			, bool isToCompareIdByFKOnlyOfSolution_S1_1, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1, valueToCompareIdByFKOnlyOfBuild_B1_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1, valueToCompareIdByFKOnlyOfSolution_S1_1)
				, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfBuild_B1_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_S1_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfBuildEventCode_B2_1 { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier(
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