using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
 
namespace ASP.NET_Core_Identity_Demo.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}
