using System;
using System.Runtime.Serialization;
using System.Linq.Expressions;
using System.Linq;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// Interaction logic for IQueryCriteriaBuildLogByFKs
    /// </summary>
	public partial interface IQueryCriteriaBuildLogByFKs
	{

        		bool IsToCompareBuildId { get; set; }
        		System.Int64 ComparedToBuildId { get; set; }
        

        		bool IsToCompareBuildEventCodeId { get; set; }
        		System.Int32 ComparedToBuildEventCodeId { get; set; }
        
	}

	#region PrediacteByFKs

    public class QueryPredicateBuildLogByFKs<T>
		where T: IBuildLog
    {
		public IQueryCriteriaBuildLogByFKs Criteria { get; set; }

        public QueryPredicateBuildLogByFKs(IQueryCriteriaBuildLogByFKs criteria)
        {
			this. Criteria = criteria;
		}

        public bool Predicate(T input)
        {
            Expression<Func<T, bool>> _retvalExpression = GetPredicateExpression();
            return _retvalExpression.Compile()(input);

            //return Criteria != null && input != null &&
//<<<<<6>>>>>;
        }

        public Expression<Func<T, bool>> GetPredicateExpression()
        {
            Expression<Func<T, bool>> _retval = input =>
                (Criteria != null && input != null &&

 (this.Criteria.IsToCompareBuildId == false || this.Criteria.IsToCompareBuildId == true && input.BuildId == this.Criteria.ComparedToBuildId)


&&(this.Criteria.IsToCompareBuildEventCodeId == false || this.Criteria.IsToCompareBuildEventCodeId == true && input.BuildEventCodeId == this.Criteria.ComparedToBuildEventCodeId)

);

            return _retval;
        }
    }

	#endregion PrediacteByID
}