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
    public partial class BuildChainedQueryCriteriaCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaCommon()
			: this(new BuildChainedQueryCriteriaCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildChainedQueryCriteriaCommon(BuildChainedQueryCriteriaCommonFlatten input)
            : this(
				input.IsToCompareIdCommonOfSolution_1OfCommon, input.ValueToCompareIdCommonOfSolution_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfSolution_1OfCommon.Value : default(int)
				, input.IsToCompareBuildStartTimeCommonOftOfCommon, input.IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon, input.LowerBoundBuildStartTimeCommonOftOfCommon.HasValue ? input.LowerBoundBuildStartTimeCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon, input.UpperBoundBuildStartTimeCommonOftOfCommon.HasValue ? input.UpperBoundBuildStartTimeCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareNameCommonOftOfCommon, input.ValueToBeContainedNameCommonOftOfCommon
				, input.IsToCompareDescriptionCommonOftOfCommon, input.ValueToBeContainedDescriptionCommonOftOfCommon
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
        /// </summary>

		public BuildChainedQueryCriteriaCommon(
			BuildQueryCriteriaCommon buildQueryCriteriaCommon			
			)
		{
			this.BuildQueryCriteriaCommon = buildQueryCriteriaCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
		/// </summary>
        /// <param name="idCommonOfSolution_1OfCommon">Initialize criteria of IdCommonOfSolution_1OfCommon</param>
        /// <param name="buildStartTimeCommonOftOfCommon">Initialize criteria of BuildStartTimeCommonOftOfCommon</param>
        /// <param name="nameCommonOftOfCommon">Initialize criteria of NameCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>	
		public BuildChainedQueryCriteriaCommon(
			QuerySystemInt32EqualsCriteria idCommonOfSolution_1OfCommon
			, QuerySystemDateTimeRangeCriteria buildStartTimeCommonOftOfCommon
			, QuerySystemStringContainsCriteria nameCommonOftOfCommon
			, QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
			)
			: this(
			new BuildQueryCriteriaCommon(idCommonOfSolution_1OfCommon,buildStartTimeCommonOftOfCommon,nameCommonOftOfCommon,descriptionCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BuildChainedQueryCriteriaCommon(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			)
			: this(
			new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BuildQueryCriteriaCommon BuildQueryCriteriaCommon { get; set; }
		#endregion Propertyies
	}

	public partial class BuildChainedQueryCriteriaCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaCommonFlatten()
		{
			this.IsToCompareIdCommonOfSolution_1OfCommon= false; this.ValueToCompareIdCommonOfSolution_1OfCommon= default(int);
			this.IsToCompareBuildStartTimeCommonOftOfCommon= false; this.IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon=false;this.LowerBoundBuildStartTimeCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon=false;this.UpperBoundBuildStartTimeCommonOftOfCommon=DateTime.Now;
			this.IsToCompareNameCommonOftOfCommon= false; this.ValueToBeContainedNameCommonOftOfCommon= null;
			this.IsToCompareDescriptionCommonOftOfCommon= false; this.ValueToBeContainedDescriptionCommonOftOfCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BuildChainedQueryCriteriaCommonFlatten(
			bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32? valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime? lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime? upperBoundBuildStartTimeCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			)
		{
			this.IsToCompareIdCommonOfSolution_1OfCommon= isToCompareIdCommonOfSolution_1OfCommon; this.ValueToCompareIdCommonOfSolution_1OfCommon= valueToCompareIdCommonOfSolution_1OfCommon;
			this.IsToCompareBuildStartTimeCommonOftOfCommon= isToCompareBuildStartTimeCommonOftOfCommon; this.IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon=isToCompareLowerBoundBuildStartTimeCommonOftOfCommon;this.LowerBoundBuildStartTimeCommonOftOfCommon=lowerBoundBuildStartTimeCommonOftOfCommon;this.IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon=isToCompareUpperBoundBuildStartTimeCommonOftOfCommon;this.UpperBoundBuildStartTimeCommonOftOfCommon=upperBoundBuildStartTimeCommonOftOfCommon;
			this.IsToCompareNameCommonOftOfCommon= isToCompareNameCommonOftOfCommon; this.ValueToBeContainedNameCommonOftOfCommon= valueToBeContainedNameCommonOftOfCommon;
			this.IsToCompareDescriptionCommonOftOfCommon= isToCompareDescriptionCommonOftOfCommon; this.ValueToBeContainedDescriptionCommonOftOfCommon= valueToBeContainedDescriptionCommonOftOfCommon;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdCommonOfSolution_1OfCommon { get; set; } public System.Int32? ValueToCompareIdCommonOfSolution_1OfCommon { get; set; }
		public bool IsToCompareBuildStartTimeCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundBuildStartTimeCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundBuildStartTimeCommonOftOfCommon { get; set; }
		public bool IsToCompareNameCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNameCommonOftOfCommon { get; set; }
		public bool IsToCompareDescriptionCommonOftOfCommon { get; set; } public System.String ValueToBeContainedDescriptionCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public partial class BuildChainedQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaAll"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildChainedQueryCriteriaAll(BuildChainedQueryCriteriaAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaAll"/> class.
        /// </summary>

		public BuildChainedQueryCriteriaAll(
			BuildQueryCriteriaAll buildQueryCriteriaAll			
			)
		{
			this.BuildQueryCriteriaAll = buildQueryCriteriaAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BuildQueryCriteriaAll BuildQueryCriteriaAll { get; set; }
		#endregion Propertyies
	}

	public partial class BuildChainedQueryCriteriaAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaAllFlatten"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildChainedQueryCriteriaByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaByFKOnly()
			: this(new BuildChainedQueryCriteriaByFKOnlyFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildChainedQueryCriteriaByFKOnly(BuildChainedQueryCriteriaByFKOnlyFlatten input)
            : this(
				input.IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>

		public BuildChainedQueryCriteriaByFKOnly(
			BuildQueryCriteriaByFKOnly buildQueryCriteriaByFKOnly			
			)
		{
			this.BuildQueryCriteriaByFKOnly = buildQueryCriteriaByFKOnly;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
		/// </summary>
        /// <param name="idByFKOnlyOfSolution_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfSolution_1OfByFKOnly</param>	
		public BuildChainedQueryCriteriaByFKOnly(
			QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1OfByFKOnly
			)
			: this(
			new BuildQueryCriteriaByFKOnly(idByFKOnlyOfSolution_1OfByFKOnly)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>	
		public BuildChainedQueryCriteriaByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			)
			: this(
			new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public BuildQueryCriteriaByFKOnly BuildQueryCriteriaByFKOnly { get; set; }
		#endregion Propertyies
	}

	public partial class BuildChainedQueryCriteriaByFKOnlyFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnlyFlatten"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaByFKOnlyFlatten()
		{
			this.IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnlyFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>	
		public BuildChainedQueryCriteriaByFKOnlyFlatten(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			)
		{
			this.IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly= isToCompareIdByFKOnlyOfSolution_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly= valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByFKOnlyOfSolution_1OfByFKOnly { get; set; } public System.Int32? ValueToCompareIdByFKOnlyOfSolution_1OfByFKOnly { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildChainedQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaByIdentifier()
			: this(new BuildChainedQueryCriteriaByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildChainedQueryCriteriaByIdentifier(BuildChainedQueryCriteriaByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(long)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

		public BuildChainedQueryCriteriaByIdentifier(
			BuildQueryCriteriaByIdentifier buildQueryCriteriaByIdentifier			
			)
		{
			this.BuildQueryCriteriaByIdentifier = buildQueryCriteriaByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BuildChainedQueryCriteriaByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BuildQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BuildChainedQueryCriteriaByIdentifier(
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
        public BuildQueryCriteriaByIdentifier BuildQueryCriteriaByIdentifier { get; set; }
		#endregion Propertyies
	}

	public partial class BuildChainedQueryCriteriaByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
		public BuildChainedQueryCriteriaByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(long);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BuildChainedQueryCriteriaByIdentifierFlatten(
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