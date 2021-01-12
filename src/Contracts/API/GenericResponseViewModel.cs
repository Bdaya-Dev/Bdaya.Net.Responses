using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bdaya.Net.Responses.Contracts.API
{
    public class GenericResponseViewModel<T> : ResponseViewModel
    {
        public T Data { get; set; }
        public GenericResponseViewModel(T data)
        {
            Data = data;
        }
    }
}
