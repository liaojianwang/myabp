using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TheEndProject.Controllers
{
    public abstract class TheEndProjectControllerBase: AbpController
    {
        protected TheEndProjectControllerBase()
        {
            LocalizationSourceName = TheEndProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
