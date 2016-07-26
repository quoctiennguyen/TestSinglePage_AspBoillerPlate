using Abp.Authorization;
using Trainer.Authorization.Roles;
using Trainer.MultiTenancy;
using Trainer.Users;

namespace Trainer.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
