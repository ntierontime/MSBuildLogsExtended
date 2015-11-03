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
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon(BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten input)
            : this(
				input.IsToCompareEventCodeCommonOftOfCommon, input.ValueToBeContainedEventCodeCommonOftOfCommon
				, input.IsToCompareDescriptionCommonOftOfCommon, input.ValueToBeContainedDescriptionCommonOftOfCommon
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon(
			BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon businessLogicLayerQueryCriteriaEntityBuildEventCodeCommon			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon = businessLogicLayerQueryCriteriaEntityBuildEventCodeCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon"/> class.
		/// </summary>
        /// <param name="eventCodeCommonOftOfCommon">Initialize criteria of EventCodeCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon(
			QuerySystemStringContainsCriteria eventCodeCommonOftOfCommon
			, QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon(eventCodeCommonOftOfCommon,descriptionCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon"/> class.
		/// </summary>
        /// <param name="isToCompareEventCodeCommonOftOfCommon">will compare/filter EventCodeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedEventCodeCommonOftOfCommon">value to compare/filter with EventCodeCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon(
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
        public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon BusinessLogicLayerQueryCriteriaEntityBuildEventCodeCommon { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten()
		{
			this.IsToCompareEventCodeCommonOftOfCommon= false; this.ValueToBeContainedEventCodeCommonOftOfCommon= null;
			this.IsToCompareDescriptionCommonOftOfCommon= false; this.ValueToBeContainedDescriptionCommonOftOfCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareEventCodeCommonOftOfCommon">will compare/filter EventCodeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedEventCodeCommonOftOfCommon">value to compare/filter with EventCodeCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommonFlatten(
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
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll(BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAll(
			BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll businessLogicLayerQueryCriteriaEntityBuildEventCodeAll			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll = businessLogicLayerQueryCriteriaEntityBuildEventCodeAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll BusinessLogicLayerQueryCriteriaEntityBuildEventCodeAll { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAllFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier(BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier(
			BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier businessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier = businessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier(
			QuerySystemInt32EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifier(
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
        public BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier BusinessLogicLayerQueryCriteriaEntityBuildEventCodeByIdentifier { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeByIdentifierFlatten(
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