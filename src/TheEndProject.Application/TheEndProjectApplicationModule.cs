using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TheEndProject.Authorization;

namespace TheEndProject
{
    [DependsOn(
        typeof(TheEndProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TheEndProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TheEndProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TheEndProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                //cfg => cfg.AddMaps(thisAssembly)
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
