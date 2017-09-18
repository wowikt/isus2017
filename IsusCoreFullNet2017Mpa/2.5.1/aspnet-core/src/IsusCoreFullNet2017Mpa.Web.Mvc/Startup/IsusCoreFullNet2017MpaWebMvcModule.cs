using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCoreFullNet2017Mpa.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IsusCoreFullNet2017Mpa.Web.Startup
{
    [DependsOn(typeof(IsusCoreFullNet2017MpaWebCoreModule))]
    public class IsusCoreFullNet2017MpaWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCoreFullNet2017MpaWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<IsusCoreFullNet2017MpaNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017MpaWebMvcModule).GetAssembly());
        }
    }
}