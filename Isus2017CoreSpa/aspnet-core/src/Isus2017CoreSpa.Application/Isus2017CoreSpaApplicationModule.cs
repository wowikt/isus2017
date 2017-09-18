using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Isus2017CoreSpa.Authorization;

namespace Isus2017CoreSpa
{
    [DependsOn(
        typeof(Isus2017CoreSpaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Isus2017CoreSpaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Isus2017CoreSpaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(Isus2017CoreSpaApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}