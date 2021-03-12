using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bdaya.Net.Responses.Cotracts.Containers
{
    public class PaginatedList<T>
    {
        /// <summary>
        /// One-based Index
        /// </summary>
        public int PageIndex { get; init; }
        public List<T> Page { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public PaginatedList()
        {
        }
        public PaginatedList(int pageIndex, int pageSize, int totalCount, List<T> page)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            Page = page;
        }

        public int TotalPages => TotalCount.CeilDiv(PageSize);

        public int PageIndexZeroBased => PageIndex - 1;
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PaginatedList<T>(pageIndex, pageSize, count, items);
        }

    }
}
