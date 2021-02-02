using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Bdaya.Net.Responses.Contracts.API
{
    public class TokenBagViewModel<TUserViewModel>
    {
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
        public TUserViewModel User { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
    }
}
