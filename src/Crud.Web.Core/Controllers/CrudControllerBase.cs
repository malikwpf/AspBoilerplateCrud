using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Crud.Controllers
{
    public abstract class CrudControllerBase: AbpController
    {
        protected CrudControllerBase()
        {
            LocalizationSourceName = CrudConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
