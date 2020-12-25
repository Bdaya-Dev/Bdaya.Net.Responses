using Microsoft.AspNetCore.Identity;

namespace Bdaya.Net.Responses.Contracts.API
{
    public class IdentityResponseViewModel : ResponseViewModel
    {
        public IdentityResult ProcessResult { get; set; }
    }
}
