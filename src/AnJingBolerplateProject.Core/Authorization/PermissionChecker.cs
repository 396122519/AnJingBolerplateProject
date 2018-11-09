using Abp.Authorization;
using AnJingBolerplateProject.Authorization.Roles;
using AnJingBolerplateProject.Authorization.Users;

namespace AnJingBolerplateProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
