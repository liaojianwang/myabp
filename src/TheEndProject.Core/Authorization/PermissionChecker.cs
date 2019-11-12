using Abp.Authorization;
using TheEndProject.Authorization.Roles;
using TheEndProject.Authorization.Users;

namespace TheEndProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
