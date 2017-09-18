using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCoreFullNet2017Spa.Authorization;

namespace IsusCoreFullNet2017Spa
{
    [DependsOn(
        typeof(IsusCoreFullNet2017SpaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IsusCoreFullNet2017SpaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IsusCoreFullNet2017SpaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(IsusCoreFullNet2017SpaApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}