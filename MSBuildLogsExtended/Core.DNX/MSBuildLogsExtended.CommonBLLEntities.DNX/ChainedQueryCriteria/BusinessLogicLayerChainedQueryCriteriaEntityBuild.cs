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
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon(BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten input)
            : this(
				input.IsToCompareIdCommonOfSolution_S1_1OfCommon, input.ValueToCompareIdCommonOfSolution_S1_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfSolution_S1_1OfCommon.Value : default(int)
				, input.IsToCompareNameCommonOftOfCommon, input.ValueToBeContainedNameCommonOftOfCommon
				, input.IsToCompareDescriptionCommonOftOfCommon, input.ValueToBeContainedDescriptionCommonOftOfCommon
				, input.IsToCompareBuildStartTimeCommonOftOfCommon, input.IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon, input.LowerBoundBuildStartTimeCommonOftOfCommon.HasValue ? input.LowerBoundBuildStartTimeCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon, input.UpperBoundBuildStartTimeCommonOftOfCommon.HasValue ? input.UpperBoundBuildStartTimeCommonOftOfCommon.Value : DateTime.Now
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon(
			BusinessLogicLayerQueryCriteriaEntityBuildCommon businessLogicLayerQueryCriteriaEntityBuildCommon			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildCommon = businessLogicLayerQueryCriteriaEntityBuildCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon"/> class.
		/// </summary>
        /// <param name="idCommonOfSolution_S1_1OfCommon">Initialize criteria of IdCommonOfSolution_S1_1OfCommon</param>
        /// <param name="nameCommonOftOfCommon">Initialize criteria of NameCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>
        /// <param name="buildStartTimeCommonOftOfCommon">Initialize criteria of BuildStartTimeCommonOftOfCommon</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon(
			QuerySystemInt32EqualsCriteria idCommonOfSolution_S1_1OfCommon
			, QuerySystemStringContainsCriteria nameCommonOftOfCommon
			, QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
			, QuerySystemDateTimeRangeCriteria buildStartTimeCommonOftOfCommon
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildCommon(idCommonOfSolution_S1_1OfCommon,nameCommonOftOfCommon,descriptionCommonOftOfCommon,buildStartTimeCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommon(
			bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime upperBoundBuildStartTimeCommonOftOfCommon
			)
			: this(
			new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_S1_1OfCommon, valueToCompareIdCommonOfSolution_S1_1OfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildCommon BusinessLogicLayerQueryCriteriaEntityBuildCommon { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten()
		{
			this.IsToCompareIdCommonOfSolution_S1_1OfCommon= false; this.ValueToCompareIdCommonOfSolution_S1_1OfCommon= default(int);
			this.IsToCompareNameCommonOftOfCommon= false; this.ValueToBeContainedNameCommonOftOfCommon= null;
			this.IsToCompareDescriptionCommonOftOfCommon= false; this.ValueToBeContainedDescriptionCommonOftOfCommon= null;
			this.IsToCompareBuildStartTimeCommonOftOfCommon= false; this.IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon=false;this.LowerBoundBuildStartTimeCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon=false;this.UpperBoundBuildStartTimeCommonOftOfCommon=DateTime.Now;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdCommonOfSolution_S1_1OfCommon">will compare/filter IdCommonOfSolution_S1_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_S1_1OfCommon">value to compare/filter with IdCommonOfSolution_S1_1OfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildCommonFlatten(
			bool isToCompareIdCommonOfSolution_S1_1OfCommon, System.Int32? valueToCompareIdCommonOfSolution_S1_1OfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime? lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime? upperBoundBuildStartTimeCommonOftOfCommon
			)
		{
			this.IsToCompareIdCommonOfSolution_S1_1OfCommon= isToCompareIdCommonOfSolution_S1_1OfCommon; this.ValueToCompareIdCommonOfSolution_S1_1OfCommon= valueToCompareIdCommonOfSolution_S1_1OfCommon;
			this.IsToCompareNameCommonOftOfCommon= isToCompareNameCommonOftOfCommon; this.ValueToBeContainedNameCommonOftOfCommon= valueToBeContainedNameCommonOftOfCommon;
			this.IsToCompareDescriptionCommonOftOfCommon= isToCompareDescriptionCommonOftOfCommon; this.ValueToBeContainedDescriptionCommonOftOfCommon= valueToBeContainedDescriptionCommonOftOfCommon;
			this.IsToCompareBuildStartTimeCommonOftOfCommon= isToCompareBuildStartTimeCommonOftOfCommon; this.IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon=isToCompareLowerBoundBuildStartTimeCommonOftOfCommon;this.LowerBoundBuildStartTimeCommonOftOfCommon=lowerBoundBuildStartTimeCommonOftOfCommon;this.IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon=isToCompareUpperBoundBuildStartTimeCommonOftOfCommon;this.UpperBoundBuildStartTimeCommonOftOfCommon=upperBoundBuildStartTimeCommonOftOfCommon;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdCommonOfSolution_S1_1OfCommon { get; set; } public System.Int32? ValueToCompareIdCommonOfSolution_S1_1OfCommon { get; set; }
		public bool IsToCompareNameCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNameCommonOftOfCommon { get; set; }
		public bool IsToCompareDescriptionCommonOftOfCommon { get; set; } public System.String ValueToBeContainedDescriptionCommonOftOfCommon { get; set; }
		public bool IsToCompareBuildStartTimeCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundBuildStartTimeCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundBuildStartTimeCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundBuildStartTimeCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundBuildStartTimeCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildAll"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildAll(BusinessLogicLayerChainedQueryCriteriaEntityBuildAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildAll"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildAll(
			BusinessLogicLayerQueryCriteriaEntityBuildAll businessLogicLayerQueryCriteriaEntityBuildAll			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildAll = businessLogicLayerQueryCriteriaEntityBuildAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildAll BusinessLogicLayerQueryCriteriaEntityBuildAll { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildAllFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly(BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten input)
            : this(
				input.IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly(
			BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly businessLogicLayerQueryCriteriaEntityBuildByFKOnly			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly = businessLogicLayerQueryCriteriaEntityBuildByFKOnly;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly"/> class.
		/// </summary>
        /// <param name="idByFKOnlyOfSolution_S1_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfSolution_S1_1OfByFKOnly</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly(
			QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_S1_1OfByFKOnly
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly(idByFKOnlyOfSolution_S1_1OfByFKOnly)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			)
			: this(
			new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly BusinessLogicLayerQueryCriteriaEntityBuildByFKOnly { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten()
		{
			this.IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_S1_1OfByFKOnly property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByFKOnlyFlatten(
			bool isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly
			)
		{
			this.IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= isToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly= valueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly { get; set; } public System.Int32? ValueToCompareIdByFKOnlyOfSolution_S1_1OfByFKOnly { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier(BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(long)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier(
			BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier businessLogicLayerQueryCriteriaEntityBuildByIdentifier			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier = businessLogicLayerQueryCriteriaEntityBuildByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifier(
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
        public BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier BusinessLogicLayerQueryCriteriaEntityBuildByIdentifier { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(long);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildByIdentifierFlatten(
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