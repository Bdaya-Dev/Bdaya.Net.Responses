using Bdaya.Net.Responses.Processors;

namespace Bdaya.Net.Responses.Cotracts.Containers
{
    public class PaginatedResponse<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int LastPageIndex { get; set; }
        public PaginatedList<T> Page { get; set; }
    }
}
