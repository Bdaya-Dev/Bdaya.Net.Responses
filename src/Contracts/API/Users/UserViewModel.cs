using System;

namespace Bdaya.Net.Responses.Contracts.API.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
