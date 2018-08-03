using Microsoft.AspNet.Identity.EntityFramework;

namespace WebBase.Models.Entities.Identity
{
    public class CustomUserStore : UserStore<ApplicationUser, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}