using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCoreFullNet2017Mpa.Authorization;

namespace IsusCoreFullNet2017Mpa
{
    [DependsOn(
        typeof(IsusCoreFullNet2017MpaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IsusCoreFullNet2017MpaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IsusCoreFullNet2017MpaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(IsusCoreFullNet2017MpaApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}