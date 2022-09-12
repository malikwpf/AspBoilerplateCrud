using Abp.Authorization;
using Crud.Authorization.Roles;
using Crud.Authorization.Users;

namespace Crud.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
