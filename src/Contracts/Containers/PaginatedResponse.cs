using Bdaya.Net.Responses.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bdaya.Net.Responses.Cotracts.Containers
{
    public class PaginatedResponse<T>
    {
        /// <summary>
        /// One-based Index
        /// </summary>
        public int PageIndex { get; init; }
        public List<T> Page { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public PaginatedResponse()
        {
        }
        public PaginatedResponse(int pageIndex, int pageSize, int totalCount, List<T> page)
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



    }
}
