using Otthonbazar.Data;
using Otthonbazar.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace NgOtthonbazar.Search
{
    public static class SearchModelClause
    {
        public static SearchModelClause<T> CreateClause<T>(Func<SearchModel, T> clauseSelector, Func<T, Expression<Func<Advertisement, bool>>> matchExpressionFactory)
            => new SearchModelClause<T>(clauseSelector, matchExpressionFactory);
    }
    public class SearchModelClause<T> : ISearchModelClause
    {
        private readonly Func<SearchModel, T> _clauseSelector;
        private readonly Func<T, Expression<Func<Advertisement, bool>>> _matchExpressionFactory;

        public SearchModelClause(Func<SearchModel, T> clauseSelector, Func<T, Expression<Func<Advertisement, bool>>> matchExpressionFactory)
        {
            _clauseSelector = clauseSelector;
            _matchExpressionFactory = matchExpressionFactory;
        }

        public IQueryable<Advertisement> ApplyClause(IQueryable<Advertisement> advertisements, SearchModel searchModel)
            => _clauseSelector(searchModel) != default ? advertisements.Where(_matchExpressionFactory(_clauseSelector(searchModel))) : advertisements;
    }
}
