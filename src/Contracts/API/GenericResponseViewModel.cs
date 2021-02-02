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
        public GenericResponseViewModel(T data, bool isSuccess = true, string message = "Success Execution")
        {
            Data = data;
            Status = isSuccess;
            Message = message;
        }
    }
}
