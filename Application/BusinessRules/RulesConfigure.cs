using System.Linq.Expressions;

namespace Application.BusinessRules
{
    public class RulesConfigure<T>
          where T : class, new()
    {
        protected virtual IQueryable<T> ConfigureIncludeSearch(IQueryable<T> IQuery, Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            return IQuery;
        }

    }
}
