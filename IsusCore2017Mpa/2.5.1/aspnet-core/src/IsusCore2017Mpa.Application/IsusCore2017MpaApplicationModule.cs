using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCore2017Mpa.Authorization;

namespace IsusCore2017Mpa
{
    [DependsOn(
        typeof(IsusCore2017MpaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IsusCore2017MpaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IsusCore2017MpaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(IsusCore2017MpaApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}