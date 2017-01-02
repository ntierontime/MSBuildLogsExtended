using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{

	public partial interface ISolutionIdentifier
	{ 

        System.Int32 Id { get; set; }

	}

    public class QueryPredicateSolutionByIdentifier<T>
        where T : ISolution
    {
        public QueryPredicateSolutionByIdentifier(ISolutionIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public ISolutionIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }


    /// <summary>
    ///  a property defined when <see cref="SolutionIdentifier"/> is used in other classes.
    /// </summary>
    public partial interface WithIdentifierContractSolution<T>
        where T : ISolutionIdentifier
    {
        T SolutionIdentifier { get; set; }
    }
}