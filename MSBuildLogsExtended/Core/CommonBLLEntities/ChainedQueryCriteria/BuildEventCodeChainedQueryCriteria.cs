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
    public partial class BuildEventCodeChainedQueryCriteriaCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
        /// </summary>
		public BuildEventCodeChainedQueryCriteriaCommon()
			: this(new BuildEventCodeChainedQueryCriteriaCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildEventCodeChainedQueryCriteriaCommon(BuildEventCodeChainedQueryCriteriaCommonFlatten input)
            : this(
				input.IsToCompareEventCodeCommonOftOfCommon, input.ValueToBeContainedEventCodeCommonOftOfCommon
				, input.IsToCompareDescriptionCommonOftOfCommon, input.ValueToBeContainedDescriptionCommonOftOfCommon
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
        /// </summary>

		public BuildEventCodeChainedQueryCriteriaCommon(
			BuildEventCodeQueryCriteriaCommon buildEventCodeQueryCriteriaCommon			
			)
		{
			this.BuildEventCodeQueryCriteriaCommon = buildEventCodeQueryCriteriaCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
		/// </summary>
        /// <param name="eventCodeCommonOftOfCommon">Initialize criteria of EventCodeCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>	
		public BuildEventCodeChainedQueryCriteriaCommon(
			QuerySystemStringContainsCriteria eventCodeCommonOftOfCommon
			, QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
			)
			: this(
			new BuildEventCodeQueryCriteriaCommon(eventCodeCommonOftOfCommon,descriptionCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
		/// </summary>
        /// <param name="isToCompareEventCodeCommonOftOfCommon">will compare/filter EventCodeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedEventCodeCommonOftOfCommon">value to compare/filter with EventCodeCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BuildEventCodeChainedQueryCriteriaCommon(
			bool isToCompareEventCodeCommonOftOfCommon, System.String valueToBeContainedEventCodeCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			)
			: this(
			new QuerySystemStringContainsCriteria(isToCompareEventCodeCommonOftOfCommon, valueToBeContainedEventCodeCommonOftOfCommon)
			, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BuildEventCodeQueryCriteriaCommon BuildEventCodeQueryCriteriaCommon { get; set; }
		#endregion Propertyies
	}

	public partial class BuildEventCodeChainedQueryCriteriaCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
		public BuildEventCodeChainedQueryCriteriaCommonFlatten()
		{
			this.IsToCompareEventCodeCommonOftOfCommon= false; this.ValueToBeContainedEventCodeCommonOftOfCommon= null;
			this.IsToCompareDescriptionCommonOftOfCommon= false; this.ValueToBeContainedDescriptionCommonOftOfCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareEventCodeCommonOftOfCommon">will compare/filter EventCodeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedEventCodeCommonOftOfCommon">value to compare/filter with EventCodeCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BuildEventCodeChainedQueryCriteriaCommonFlatten(
			bool isToCompareEventCodeCommonOftOfCommon, System.String valueToBeContainedEventCodeCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			)
		{
			this.IsToCompareEventCodeCommonOftOfCommon= isToCompareEventCodeCommonOftOfCommon; this.ValueToBeContainedEventCodeCommonOftOfCommon= valueToBeContainedEventCodeCommonOftOfCommon;
			this.IsToCompareDescriptionCommonOftOfCommon= isToCompareDescriptionCommonOftOfCommon; this.ValueToBeContainedDescriptionCommonOftOfCommon= valueToBeContainedDescriptionCommonOftOfCommon;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareEventCodeCommonOftOfCommon { get; set; } public System.String ValueToBeContainedEventCodeCommonOftOfCommon { get; set; }
		public bool IsToCompareDescriptionCommonOftOfCommon { get; set; } public System.String ValueToBeContainedDescriptionCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public partial class BuildEventCodeChainedQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaAll"/> class.
        /// </summary>
		public BuildEventCodeChainedQueryCriteriaAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildEventCodeChainedQueryCriteriaAll(BuildEventCodeChainedQueryCriteriaAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaAll"/> class.
        /// </summary>

		public BuildEventCodeChainedQueryCriteriaAll(
			BuildEventCodeQueryCriteriaAll buildEventCodeQueryCriteriaAll			
			)
		{
			this.BuildEventCodeQueryCriteriaAll = buildEventCodeQueryCriteriaAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BuildEventCodeQueryCriteriaAll BuildEventCodeQueryCriteriaAll { get; set; }
		#endregion Propertyies
	}

	public partial class BuildEventCodeChainedQueryCriteriaAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaAllFlatten"/> class.
        /// </summary>
		public BuildEventCodeChainedQueryCriteriaAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildEventCodeChainedQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public BuildEventCodeChainedQueryCriteriaByIdentifier()
			: this(new BuildEventCodeChainedQueryCriteriaByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BuildEventCodeChainedQueryCriteriaByIdentifier(BuildEventCodeChainedQueryCriteriaByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

		public BuildEventCodeChainedQueryCriteriaByIdentifier(
			BuildEventCodeQueryCriteriaByIdentifier buildEventCodeQueryCriteriaByIdentifier			
			)
		{
			this.BuildEventCodeQueryCriteriaByIdentifier = buildEventCodeQueryCriteriaByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BuildEventCodeChainedQueryCriteriaByIdentifier(
			QuerySystemInt32EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BuildEventCodeQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BuildEventCodeChainedQueryCriteriaByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			)
			: this(
			new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public BuildEventCodeQueryCriteriaByIdentifier BuildEventCodeQueryCriteriaByIdentifier { get; set; }
		#endregion Propertyies
	}

	public partial class BuildEventCodeChainedQueryCriteriaByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
		public BuildEventCodeChainedQueryCriteriaByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BuildEventCodeChainedQueryCriteriaByIdentifierFlatten(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32? valueToCompareIdByIdentifierOftOfByIdentifier
			)
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= isToCompareIdByIdentifierOftOfByIdentifier; this.ValueToCompareIdByIdentifierOftOfByIdentifier= valueToCompareIdByIdentifierOftOfByIdentifier;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByIdentifierOftOfByIdentifier { get; set; } public System.Int32? ValueToCompareIdByIdentifierOftOfByIdentifier { get; set; }

		#endregion Propertyies
	}



}