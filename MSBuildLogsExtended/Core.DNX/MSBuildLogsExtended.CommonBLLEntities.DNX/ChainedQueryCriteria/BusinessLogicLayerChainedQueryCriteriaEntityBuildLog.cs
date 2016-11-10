using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.EntityContracts;
using Framework;

namespace MSBuildLogsExtended.CommonBLLEntities
{

    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Common
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten input)
            : this(
				input.IsToCompareIdCommonOfBuild_B1_1OfCommon, input.ValueToCompareIdCommonOfBuild_B1_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfBuild_B1_1OfCommon.Value : default(long)
				, input.IsToCompareIdCommonOfSolution_S1_1OfCommon, input.ValueToCompareIdCommonOfSolution_S1_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfSolution_S1_1OfCommon.Value : default(int)
				, input.IsToCompareIdCommonOfBuildEventCode_B2_1OfCommon, input.ValueToCompareIdCommonOfBuildEventCode_B2_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfBuildEventCode_B2_1OfCommon.Value : default(int)
				, input.IsToCompareMessageCommonOftOfCommon, input.ValueToBeContainedMessageCommonOftOfCommon
				, input.IsToCompareEventTimeCommonOftOfCommon, input.IsToCompareLowerBoundEventTimeCommonOftOfCommon, input.LowerBoundEventTimeCommonOftOfCommon.HasValue ? input.LowerBoundEventTimeCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundEventTimeCommonOftOfCommon, input.UpperBoundEventTimeCommonOftOfCommon.HasValue ? input.UpperBoundEventTimeCommonOftOfCommon.Value : DateTime.Now
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
			BusinessLogicLayerQueryCriteriaEntityBuildLogCommon businessLogicLayerQueryCriteriaEntityBuildLogCommon			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildLogCommon = businessLogicLayerQueryCriteriaEntityBuildLogCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon"/> class.
		/// </summary>
        /// <param name="idCommonOfBuild_B1_1OfCommon">Initialize criteria of IdCommonOfBuild_B1_1OfCommon</param>
        /// <param name="idCommonOfSolution_S1_1OfCommon">Initialize criteria of IdCommonOfSolution_S1_1OfCommon</param>
        /// <param name="idCommonOfBuildEventCode_B2_1OfCommon">Initialize criteria of IdCommonOfBuildEventCode_B2_1OfCommon</param>
        /// <param name="messageCommonOftOfCommon">Initialize criteria of MessageCommonOftOfCommon</param>
        /// <param name="eventTimeCommonOftOfCommon">Initialize criteria of EventTimeCommonOftOfCommon</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
			QuerySystemInt64EqualsCriteria idCommonOfBuild_B1_1OfCommon
			, QuerySystemInt32EqualsCriteria idCommonOfSolution_S1_1OfCommon
			, QuerySystemInt32EqualsCriteria idCommonOfBuildEventCode_B2_1OfCommon
			, QuerySystemStringContainsCriteria messageCommonOftOfCommon
			, QuerySystemDateTimeRangeCriteria eventTimeCommonOftOfCommon
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildLogCommon(idCommonOfBuild_B1_1OfCommon,idCommonOfSolution_S1_1OfCommon,idCommonOfBuildEventCode_B2_1OfCommon,messageCommonOftOfCommon,eventTimeCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommon(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_B1_1OfCommon, valueToCompareIdCommonOfBuild_B1_1OfCommon)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildLogCommon BusinessLogicLayerQueryCriteriaEntityBuildLogCommon { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten()
		{
			this.IsToCompareIdCommonOfBuild_B1_1OfCommon= false; this.ValueToCompareIdCommonOfBuild_B1_1OfCommon= default(long);
			this.IsToCompareIdCommonOfSolution_S1_1OfCommon= false; this.ValueToCompareIdCommonOfSolution_S1_1OfCommon= default(int);
			this.IsToCompareIdCommonOfBuildEventCode_B2_1OfCommon= false; this.ValueToCompareIdCommonOfBuildEventCode_B2_1OfCommon= default(int);
			this.IsToCompareMessageCommonOftOfCommon= false; this.ValueToBeContainedMessageCommonOftOfCommon= null;
			this.IsToCompareEventTimeCommonOftOfCommon= false; this.IsToCompareLowerBoundEventTimeCommonOftOfCommon=false;this.LowerBoundEventTimeCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundEventTimeCommonOftOfCommon=false;this.UpperBoundEventTimeCommonOftOfCommon=DateTime.Now;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfBuild_B1_1OfCommon">will compare/filter IdCommonOfBuild_B1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_B1_1OfCommon">value to compare/filter with IdCommonOfBuild_B1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_B2_1OfCommon">will compare/filter IdCommonOfBuildEventCode_B2_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_B2_1OfCommon property/field/column</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogCommonFlatten(
			bool isToCompareIdCommonOfBuild_B1_1OfCommon, System.Int64? valueToCompareIdCommonOfBuild_B1_1OfCommon
			, bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32? valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_B2_1OfCommon, System.Int32? valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime? lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime? upperBoundEventTimeCommonOftOfCommon
			)
		{
			this.IsToCompareIdCommonOfBuild_B1_1OfCommon= isToCompareIdCommonOfBuild_B1_1OfCommon; this.ValueToCompareIdCommonOfBuild_B1_1OfCommon= valueToCompareIdCommonOfBuild_B1_1OfCommon;
			this.IsToCompareIdCommonOfSolution_S1_1OfCommon= isToCompareIdCommonOfSolution_S1_1OfCommon; this.ValueToCompareIdCommonOfSolution_S1_1OfCommon= valueToCompareIdCommonOfSolution_S1_1OfCommon;
			this.IsToCompareIdCommonOfBuildEventCode_B2_1OfCommon= isToCompareIdCommonOfBuildEventCode_B2_1OfCommon; this.ValueToCompareIdCommonOfBuildEventCode_B2_1OfCommon= valueToCompareIdCommonOfBuildEventCode_B2_1OfCommon;
			this.IsToCompareMessageCommonOftOfCommon= isToCompareMessageCommonOftOfCommon; this.ValueToBeContainedMessageCommonOftOfCommon= valueToBeContainedMessageCommonOftOfCommon;
			this.IsToCompareEventTimeCommonOftOfCommon= isToCompareEventTimeCommonOftOfCommon; this.IsToCompareLowerBoundEventTimeCommonOftOfCommon=isToCompareLowerBoundEventTimeCommonOftOfCommon;this.LowerBoundEventTimeCommonOftOfCommon=lowerBoundEventTimeCommonOftOfCommon;this.IsToCompareUpperBoundEventTimeCommonOftOfCommon=isToCompareUpperBoundEventTimeCommonOftOfCommon;this.UpperBoundEventTimeCommonOftOfCommon=upperBoundEventTimeCommonOftOfCommon;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdCommonOfBuild_B1_1OfCommon { get; set; } public System.Int64? ValueToCompareIdCommonOfBuild_B1_1OfCommon { get; set; }
		public bool IsToCompareIdCommonOfSolution_S1_1OfCommon { get; set; } public System.Int32? ValueToCompareIdCommonOfSolution_S1_1OfCommon { get; set; }
		public bool IsToCompareIdCommonOfBuildEventCode_B2_1OfCommon { get; set; } public System.Int32? ValueToCompareIdCommonOfBuildEventCode_B2_1OfCommon { get; set; }
		public bool IsToCompareMessageCommonOftOfCommon { get; set; } public System.String ValueToBeContainedMessageCommonOftOfCommon { get; set; }
		public bool IsToCompareEventTimeCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundEventTimeCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundEventTimeCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundEventTimeCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundEventTimeCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAll(
			BusinessLogicLayerQueryCriteriaEntityBuildLogAll businessLogicLayerQueryCriteriaEntityBuildLogAll			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildLogAll = businessLogicLayerQueryCriteriaEntityBuildLogAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildLogAll BusinessLogicLayerQueryCriteriaEntityBuildLogAll { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAllFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten input)
            : this(
				input.IsToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly.Value : default(long)
				, input.IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly.Value : default(int)
				, input.IsToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
			BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly businessLogicLayerQueryCriteriaEntityBuildLogByFKOnly			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly = businessLogicLayerQueryCriteriaEntityBuildLogByFKOnly;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly"/> class.
		/// </summary>
        /// <param name="idByFKOnlyOfBuild_B1_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfBuild_B1_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfSolution_S1_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfSolution_S1_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
			QuerySystemInt64EqualsCriteria idByFKOnlyOfBuild_B1_1OfByFKOnly
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_S1_1OfByFKOnly
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly(idByFKOnlyOfBuild_B1_1OfByFKOnly,idByFKOnlyOfSolution_S1_1OfByFKOnly,idByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly BusinessLogicLayerQueryCriteriaEntityBuildLogByFKOnly { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten()
		{
			this.IsToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly= default(long);
			this.IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= default(int);
			this.IsToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_B1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByFKOnlyFlatten(
			bool isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly
			)
		{
			this.IsToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly= isToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly= valueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly;
			this.IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly;
			this.IsToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly= isToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly= valueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly { get; set; } public System.Int64? ValueToCompareIdByFKOnlyOfBuild_B1_1OfByFKOnly { get; set; }
		public bool IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly { get; set; } public System.Int32? ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly { get; set; }
		public bool IsToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly { get; set; } public System.Int32? ValueToCompareIdByFKOnlyOfBuildEventCode_B2_1OfByFKOnly { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(long)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
			BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier businessLogicLayerQueryCriteriaEntityBuildLogByIdentifier			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier = businessLogicLayerQueryCriteriaEntityBuildLogByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier BusinessLogicLayerQueryCriteriaEntityBuildLogByIdentifier { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(long);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildLogByIdentifierFlatten(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64? valueToCompareIdByIdentifierOftOfByIdentifier
			)
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= isToCompareIdByIdentifierOftOfByIdentifier; this.ValueToCompareIdByIdentifierOftOfByIdentifier= valueToCompareIdByIdentifierOftOfByIdentifier;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByIdentifierOftOfByIdentifier { get; set; } public System.Int64? ValueToCompareIdByIdentifierOftOfByIdentifier { get; set; }

		#endregion Propertyies
	}



}