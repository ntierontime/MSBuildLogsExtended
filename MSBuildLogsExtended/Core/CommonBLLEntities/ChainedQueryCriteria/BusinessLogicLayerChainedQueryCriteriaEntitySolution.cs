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
    public class BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon(BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten input)
            : this(
				input.IsToCompareExternalParentIdCommonOftOfCommon, input.ValueToBeContainedExternalParentIdCommonOftOfCommon
				, input.IsToCompareNameCommonOftOfCommon, input.ValueToBeContainedNameCommonOftOfCommon
				, input.IsToCompareDescriptionCommonOftOfCommon, input.ValueToBeContainedDescriptionCommonOftOfCommon
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon(
			BusinessLogicLayerQueryCriteriaEntitySolutionCommon businessLogicLayerQueryCriteriaEntitySolutionCommon			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntitySolutionCommon = businessLogicLayerQueryCriteriaEntitySolutionCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon"/> class.
		/// </summary>
        /// <param name="externalParentIdCommonOftOfCommon">Initialize criteria of ExternalParentIdCommonOftOfCommon</param>
        /// <param name="nameCommonOftOfCommon">Initialize criteria of NameCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon(
			QuerySystemStringContainsCriteria externalParentIdCommonOftOfCommon
			, QuerySystemStringContainsCriteria nameCommonOftOfCommon
			, QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntitySolutionCommon(externalParentIdCommonOftOfCommon,nameCommonOftOfCommon,descriptionCommonOftOfCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon"/> class.
		/// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			)
			: this(
			new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
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
        public BusinessLogicLayerQueryCriteriaEntitySolutionCommon BusinessLogicLayerQueryCriteriaEntitySolutionCommon { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten()
		{
			this.IsToCompareExternalParentIdCommonOftOfCommon= false; this.ValueToBeContainedExternalParentIdCommonOftOfCommon= null;
			this.IsToCompareNameCommonOftOfCommon= false; this.ValueToBeContainedNameCommonOftOfCommon= null;
			this.IsToCompareDescriptionCommonOftOfCommon= false; this.ValueToBeContainedDescriptionCommonOftOfCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionCommonFlatten(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			)
		{
			this.IsToCompareExternalParentIdCommonOftOfCommon= isToCompareExternalParentIdCommonOftOfCommon; this.ValueToBeContainedExternalParentIdCommonOftOfCommon= valueToBeContainedExternalParentIdCommonOftOfCommon;
			this.IsToCompareNameCommonOftOfCommon= isToCompareNameCommonOftOfCommon; this.ValueToBeContainedNameCommonOftOfCommon= valueToBeContainedNameCommonOftOfCommon;
			this.IsToCompareDescriptionCommonOftOfCommon= isToCompareDescriptionCommonOftOfCommon; this.ValueToBeContainedDescriptionCommonOftOfCommon= valueToBeContainedDescriptionCommonOftOfCommon;
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareExternalParentIdCommonOftOfCommon { get; set; } public System.String ValueToBeContainedExternalParentIdCommonOftOfCommon { get; set; }
		public bool IsToCompareNameCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNameCommonOftOfCommon { get; set; }
		public bool IsToCompareDescriptionCommonOftOfCommon { get; set; } public System.String ValueToBeContainedDescriptionCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(BusinessLogicLayerChainedQueryCriteriaEntitySolutionAllFlatten input)
            : this(

			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionAll(
			BusinessLogicLayerQueryCriteriaEntitySolutionAll businessLogicLayerQueryCriteriaEntitySolutionAll			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntitySolutionAll = businessLogicLayerQueryCriteriaEntitySolutionAll;
		}


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BusinessLogicLayerQueryCriteriaEntitySolutionAll BusinessLogicLayerQueryCriteriaEntitySolutionAll { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntitySolutionAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionAllFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier()
			: this(new BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier(BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(int)
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier"/> class.
        /// </summary>

		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier(
			BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier businessLogicLayerQueryCriteriaEntitySolutionByIdentifier			
			)
		{
			this.BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier = businessLogicLayerQueryCriteriaEntitySolutionByIdentifier;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier"/> class.
		/// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier(
			QuerySystemInt32EqualsCriteria idByIdentifierOftOfByIdentifier
			)
			: this(
			new BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier(idByIdentifierOftOfByIdentifier)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifier(
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
        public BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier BusinessLogicLayerQueryCriteriaEntitySolutionByIdentifier { get; set; }
		#endregion Propertyies
	}

	public class BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten"/> class.
        /// </summary>
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(int);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public BusinessLogicLayerChainedQueryCriteriaEntitySolutionByIdentifierFlatten(
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