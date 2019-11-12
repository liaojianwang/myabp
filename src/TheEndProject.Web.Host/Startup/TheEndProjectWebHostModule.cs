using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TheEndProject.Configuration;

namespace TheEndProject.Web.Host.Startup
{
    [DependsOn(
       typeof(TheEndProjectWebCoreModule))]
    public class TheEndProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TheEndProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TheEndProjectWebHostModule).GetAssembly());
        }
    }
}
