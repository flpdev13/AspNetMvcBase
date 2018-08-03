using Microsoft.AspNet.Identity.EntityFramework;

namespace WebBase.Models.Entities.Identity
{
    public class CustomRoleStore : RoleStore<CustomRole, int, CustomUserRole>
    {
        public CustomRoleStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}