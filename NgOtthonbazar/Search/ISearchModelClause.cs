using Otthonbazar.Data;
using Otthonbazar.Models;
using System.Linq;

namespace NgOtthonbazar.Search
{
    public interface ISearchModelClause
    {
        IQueryable<Advertisement> ApplyClause(IQueryable<Advertisement> advertisements, SearchModel searchModel);
    }
}
