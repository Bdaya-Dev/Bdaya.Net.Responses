using Bdaya.Net.Responses.Cotracts.Containers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bdaya.Net.Responses.Processors
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedResponse<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {

            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedResponse<T>
            {
                Page = new PaginatedList<T>(items, count, pageIndex, pageSize),
                PageSize = pageSize,
                PageIndex = pageIndex,
                LastPageIndex = count
            };
        }
    }
}
