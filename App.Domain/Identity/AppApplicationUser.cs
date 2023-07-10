using App.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Identity
{
    public class AppApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual ShoppingCart UserCart { get; set; }
    }
}
