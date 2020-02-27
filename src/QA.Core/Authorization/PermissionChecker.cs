using Abp.Authorization;
using QA.Authorization.Roles;
using QA.Authorization.Users;

namespace QA.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
