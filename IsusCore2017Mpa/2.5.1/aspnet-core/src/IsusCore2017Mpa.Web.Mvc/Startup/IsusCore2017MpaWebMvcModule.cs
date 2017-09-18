using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCore2017Mpa.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IsusCore2017Mpa.Web.Startup
{
    [DependsOn(typeof(IsusCore2017MpaWebCoreModule))]
    public class IsusCore2017MpaWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCore2017MpaWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<IsusCore2017MpaNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCore2017MpaWebMvcModule).GetAssembly());
        }
    }
}