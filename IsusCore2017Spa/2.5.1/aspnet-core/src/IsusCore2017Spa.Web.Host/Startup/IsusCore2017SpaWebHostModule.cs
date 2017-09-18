using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCore2017Spa.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IsusCore2017Spa.Web.Host.Startup
{
    [DependsOn(
       typeof(IsusCore2017SpaWebCoreModule))]
    public class IsusCore2017SpaWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCore2017SpaWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCore2017SpaWebHostModule).GetAssembly());
        }
    }
}
