using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCore2017Spa.Authorization;

namespace IsusCore2017Spa
{
    [DependsOn(
        typeof(IsusCore2017SpaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IsusCore2017SpaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IsusCore2017SpaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(IsusCore2017SpaApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}