using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{

	public interface IBuildEventCodeIdentifier
	{ 

        System.Int32 Id { get; set; }

	}

    public class QueryPredicateBuildEventCodeByIdentifier<T>
        where T : IBuildEventCode
    {
        public QueryPredicateBuildEventCodeByIdentifier(IBuildEventCodeIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public IBuildEventCodeIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }


    /// <summary>
    ///  a property defined when <see cref="BuildEventCodeIdentifier"/> is used in other classes.
    /// </summary>
    public interface WithIdentifierContractBuildEventCode<T>
        where T : IBuildEventCodeIdentifier
    {
        T BuildEventCodeIdentifier { get; set; }
    }
}