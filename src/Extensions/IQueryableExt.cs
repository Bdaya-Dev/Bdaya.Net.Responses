using Bdaya.Net.Responses.Cotracts.Containers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class IQueryableExt
    {
        public static async Task<PaginatedResponse<TTarget>> GetPaginatedResponseAsync<TSrc, TTarget>(this IOrderedQueryable<TSrc> srcQuery, int pageIndex, int pageSize, Func<Task<int>> countFunc, Expression<Func<TSrc, TTarget>> mapper)
        {
            var paginated = srcQuery.Paginate(
                pageIndex: pageIndex,
                pageSize: pageSize)
                .Select(mapper);
            return new(pageIndex: pageIndex, pageSize: pageSize, totalCount: await countFunc(), page: await paginated.ToListAsync());
        }
        public static IQueryable<T> Paginate<T>(this IOrderedQueryable<T> srcQ, int pageIndex, int pageSize)
        {
            return srcQ.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }
}
