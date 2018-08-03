using Microsoft.AspNet.Identity.EntityFramework;

namespace WebBase.Models.Entities.Identity
{
    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }
}