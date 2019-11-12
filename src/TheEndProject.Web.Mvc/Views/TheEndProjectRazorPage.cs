using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace TheEndProject.Web.Views
{
    public abstract class TheEndProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TheEndProjectRazorPage()
        {
            LocalizationSourceName = TheEndProjectConsts.LocalizationSourceName;
        }
    }
}
