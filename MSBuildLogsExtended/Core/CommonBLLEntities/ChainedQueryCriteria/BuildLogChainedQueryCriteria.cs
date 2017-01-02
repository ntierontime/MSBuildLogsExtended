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
    public partial class BuildLogChainedQueryCriteriaCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaCommon()
			: this(new BuildLogChainedQueryCriteriaCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildLogChainedQueryCriteriaCommon(BuildLogChainedQueryCriteriaCommonFlatten input)
            : this(
				input.IsToCompareIdCommonOfBuild_1OfCommon, input.ValueToCompareIdCommonOfBuild_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfBuild_1OfCommon.Value : default(long)
				, input.IsToCompareIdCommonOfSolution_1OfCommon, input.ValueToCompareIdCommonOfSolution_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfSolution_1OfCommon.Value : default(int)
				, input.IsToCompareIdCommonOfBuildEventCode_1OfCommon, input.ValueToCompareIdCommonOfBuildEventCode_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfBuildEventCode_1OfCommon.Value : default(int)
				, input.IsToCompareEventTimeCommonOftOfCommon, input.IsToCompareLowerBoundEventTimeCommonOftOfCommon, input.LowerBoundEventTimeCommonOftOfCommon.HasValue ? input.LowerBoundEventTimeCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundEventTimeCommonOftOfCommon, input.UpperBoundEventTimeCommonOftOfCommon.HasValue ? input.UpperBoundEventTimeCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareMessageCommonOftOfCommon, input.ValueToBeContainedMessageCommonOftOfCommon
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
        /// </summary>

		public BuildLogChainedQueryCriteriaCommon(
			BuildLogQueryCriteriaCommon buildLogQueryCriteriaCommon			
			)
		{
			this.BuildLogQueryCriteriaCommon = buildLogQueryCriteriaCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
		/// </summary>
        /// <param name="idCommonOfBuild_1OfCommon">Initialize criteria of IdCommonOfBuild_1OfCommon</param>
        /// <param name="idCommonOfSolution_1OfCommon">Initialize criteria of IdCommonOfSolution_1OfCommon</param>
        /// <param name="idCommonOfBuildEventCode_1OfCommon">Initialize criteria of IdCommonOfBuildEventCode_1OfCommon</param>
        /// <param name="eventTimeCommonOftOfCommon">Initialize criteria of EventTimeCommonOftOfCommon</param>
        /// <param name="messageCommonOftOfCommon">Initialize criteria of MessageCommonOftOfCommon</param>	
		public BuildLogChainedQueryCriteriaCommon(
			QuerySystemInt64EqualsCriteria idCommonOfBuild_1OfCommon
			, QuerySystemInt32EqualsCriteria idCommonOfSolution_1OfCommon
			, QuerySystemInt32EqualsCriteria idCommonOfBuildEventCode_1OfCommon
			, QuerySystemDateTimeRangeCriteria eventTimeCommonOftOfCommon
			, QuerySystemStringContainsCriteria messageCommonOftOfCommon
			)
			: this(
			new BuildLogQueryCriteriaCommon(idCommonOfBuild_1OfCommon,idCommonOfSolution_1OfCommon,idCommonOfBuildEventCode_1OfCommon,eventTimeCommonOftOfCommon,messageCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>	
		public BuildLogChainedQueryCriteriaCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_1OfCommon, valueToCompareIdCommonOfBuild_1OfCommon)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_1OfCommon, valueToCompareIdCommonOfBuildEventCode_1OfCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BuildLogQueryCriteriaCommon BuildLogQueryCriteriaCommon { get; set; }
		#endregion Propertyies
	}

	public partial class BuildLogChainedQueryCriteriaCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaCommonFlatten()
		{
			this.IsToCompareIdCommonOfBuild_1OfCommon= false; this.ValueToCompareIdCommonOfBuild_1OfCommon= default(long);
			this.IsToCompareIdCommonOfSolution_1OfCommon= false; this.ValueToCompareIdCommonOfSolution_1OfCommon= default(int);
			this.IsToCompareIdCommonOfBuildEventCode_1OfCommon= false; this.ValueToCompareIdCommonOfBuildEventCode_1OfCommon= default(int);
			this.IsToCompareEventTimeCommonOftOfCommon= false; this.IsToCompareLowerBoundEventTimeCommonOftOfCommon=false;this.LowerBoundEventTimeCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundEventTimeCommonOftOfCommon=false;this.UpperBoundEventTimeCommonOftOfCommon=DateTime.Now;
			this.IsToCompareMessageCommonOftOfCommon= false; this.ValueToBeContainedMessageCommonOftOfCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>	
		public BuildLogChainedQueryCriteriaCommonFlatten(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64? valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32? valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32? valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime? lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime? upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			)
		{
			this.IsToCompareIdCommonOfBuild_1OfCommon= isToCompareIdCommonOfBuild_1OfCommon; this.ValueToCompareIdCommonOfBuild_1OfCommon= valueToCompareIdCommonOfBuild_1OfCommon;
			this.IsToCompareIdCommonOfSolution_1OfCommon= isToCompareIdCommonOfSolution_1OfCommon; this.ValueToCompareIdCommonOfSolution_1OfCommon= valueToCompareIdCommonOfSolution_1OfCommon;
			this.IsToCompareIdCommonOfBuildEventCode_1OfCommon= isToCompareIdCommonOfBuildEventCode_1OfCommon; this.ValueToCompareIdCommonOfBuildEventCode_1OfCommon= valueToCompareIdCommonOfBuildEventCode_1OfCommon;
			this.IsToCompareEventTimeCommonOftOfCommon= isToCompareEventTimeCommonOftOfCommon; this.IsToCompareLowerBoundEventTimeCommonOftOfCommon=isToCompareLowerBoundEventTimeCommonOftOfCommon;this.LowerBoundEventTimeCommonOftOfCommon=lowerBoundEventTimeCommonOftOfCommon;this.IsToCompareUpperBoundEventTimeCommonOftOfCommon=isToCompareUpperBoundEventTimeCommonOftOfCommon;this.UpperBoundEventTimeCommonOftOfCommon=upperBoundEventTimeCommonOftOfCommon;
			this.IsToCompareMessageCommonOftOfCommon= isToCompareMessageCommonOftOfCommon; this.ValueToBeContainedMessageCommonOftOfCommon= valueToBeContainedMessageCommonOftOfCommon;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdCommonOfBuild_1OfCommon { get; set; } public System.Int64? ValueToCompareIdCommonOfBuild_1OfCommon { get; set; }
		public bool IsToCompareIdCommonOfSolution_1OfCommon { get; set; } public System.Int32? ValueToCompareIdCommonOfSolution_1OfCommon { get; set; }
		public bool IsToCompareIdCommonOfBuildEventCode_1OfCommon { get; set; } public System.Int32? ValueToCompareIdCommonOfBuildEventCode_1OfCommon { get; set; }
		public bool IsToCompareEventTimeCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundEventTimeCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundEventTimeCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundEventTimeCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundEventTimeCommonOftOfCommon { get; set; }
		public bool IsToCompareMessageCommonOftOfCommon { get; set; } public System.String ValueToBeContainedMessageCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public partial class BuildLogChainedQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaAll"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildLogChainedQueryCriteriaAll(BuildLogChainedQueryCriteriaAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaAll"/> class.
        /// </summary>

		public BuildLogChainedQueryCriteriaAll(
			BuildLogQueryCriteriaAll buildLogQueryCriteriaAll			
			)
		{
			this.BuildLogQueryCriteriaAll = buildLogQueryCriteriaAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BuildLogQueryCriteriaAll BuildLogQueryCriteriaAll { get; set; }
		#endregion Propertyies
	}

	public partial class BuildLogChainedQueryCriteriaAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaAllFlatten"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildLogChainedQueryCriteriaByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaByFKOnly()
			: this(new BuildLogChainedQueryCriteriaByFKOnlyFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildLogChainedQueryCriteriaByFKOnly(BuildLogChainedQueryCriteriaByFKOnlyFlatten input)
            : this(
				input.IsToCompareIdByFKOnlyOfBuild_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfBuild_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfBuild_1OfByFKOnly.Value : default(long)
				, input.IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.Value : default(int)
				, input.IsToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>

		public BuildLogChainedQueryCriteriaByFKOnly(
			BuildLogQueryCriteriaByFKOnly buildLogQueryCriteriaByFKOnly			
			)
		{
			this.BuildLogQueryCriteriaByFKOnly = buildLogQueryCriteriaByFKOnly;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
		/// </summary>
        /// <param name="idByFKOnlyOfBuild_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfBuild_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfSolution_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfSolution_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfBuildEventCode_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfBuildEventCode_1OfByFKOnly</param>	
		public BuildLogChainedQueryCriteriaByFKOnly(
			QuerySystemInt64EqualsCriteria idByFKOnlyOfBuild_1OfByFKOnly
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1OfByFKOnly
			, QuerySystemInt32EqualsCriteria idByFKOnlyOfBuildEventCode_1OfByFKOnly
			)
			: this(
			new BuildLogQueryCriteriaByFKOnly(idByFKOnlyOfBuild_1OfByFKOnly,idByFKOnlyOfSolution_1OfByFKOnly,idByFKOnlyOfBuildEventCode_1OfByFKOnly)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>	
		public BuildLogChainedQueryCriteriaByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
			, new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public BuildLogQueryCriteriaByFKOnly BuildLogQueryCriteriaByFKOnly { get; set; }
		#endregion Propertyies
	}

	public partial class BuildLogChainedQueryCriteriaByFKOnlyFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnlyFlatten"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaByFKOnlyFlatten()
		{
			this.IsToCompareIdByFKOnlyOfBuild_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfBuild_1OfByFKOnly= default(long);
			this.IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly= default(int);
			this.IsToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnlyFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>	
		public BuildLogChainedQueryCriteriaByFKOnlyFlatten(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			)
		{
			this.IsToCompareIdByFKOnlyOfBuild_1OfByFKOnly= isToCompareIdByFKOnlyOfBuild_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfBuild_1OfByFKOnly= valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly;
			this.IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly= isToCompareIdByFKOnlyOfSolution_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly= valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly;
			this.IsToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly= isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly= valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByFKOnlyOfBuild_1OfByFKOnly { get; set; } public System.Int64? ValueToCompareIdByFKOnlyOfBuild_1OfByFKOnly { get; set; }
		public bool IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly { get; set; } public System.Int32? ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly { get; set; }
		public bool IsToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly { get; set; } public System.Int32? ValueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildLogChainedQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaByIdentifier()
			: this(new BuildLogChainedQueryCriteriaByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildLogChainedQueryCriteriaByIdentifier(BuildLogChainedQueryCriteriaByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(long)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

		public BuildLogChainedQueryCriteriaByIdentifier(
			BuildLogQueryCriteriaByIdentifier buildLogQueryCriteriaByIdentifier			
			)
		{
			this.BuildLogQueryCriteriaByIdentifier = buildLogQueryCriteriaByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BuildLogChainedQueryCriteriaByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BuildLogQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BuildLogChainedQueryCriteriaByIdentifier(
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
        public BuildLogQueryCriteriaByIdentifier BuildLogQueryCriteriaByIdentifier { get; set; }
		#endregion Propertyies
	}

	public partial class BuildLogChainedQueryCriteriaByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
		public BuildLogChainedQueryCriteriaByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(long);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BuildLogChainedQueryCriteriaByIdentifierFlatten(
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