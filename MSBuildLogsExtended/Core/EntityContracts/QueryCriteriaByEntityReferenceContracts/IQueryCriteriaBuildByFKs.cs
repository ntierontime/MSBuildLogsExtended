using System;
using System.Runtime.Serialization;
using System.Linq.Expressions;
using System.Linq;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// Interaction logic for IQueryCriteriaBuildByFKs
    /// </summary>
	public interface IQueryCriteriaBuildByFKs
	{

        		bool IsToCompareSolutionId { get; set; }
        		System.Int32 ComparedToSolutionId { get; set; }
        
	}

	#region PrediacteByFKs

    public class QueryPredicateBuildByFKs<T>
		where T: IBuild
    {
		public IQueryCriteriaBuildByFKs Criteria { get; set; }

        public QueryPredicateBuildByFKs(IQueryCriteriaBuildByFKs criteria)
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

 (this.Criteria.IsToCompareSolutionId == false || this.Criteria.IsToCompareSolutionId == true && input.SolutionId == this.Criteria.ComparedToSolutionId)

);

            return _retval;
        }
    }

	#endregion PrediacteByID
}