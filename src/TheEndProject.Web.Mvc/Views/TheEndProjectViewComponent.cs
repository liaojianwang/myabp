using Abp.AspNetCore.Mvc.ViewComponents;

namespace TheEndProject.Web.Views
{
    public abstract class TheEndProjectViewComponent : AbpViewComponent
    {
        protected TheEndProjectViewComponent()
        {
            LocalizationSourceName = TheEndProjectConsts.LocalizationSourceName;
        }
    }
}
