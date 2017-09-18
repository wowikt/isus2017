using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IsusCoreFullNet2017Spa.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IsusCoreFullNet2017Spa.Web.Host.Startup
{
    [DependsOn(
       typeof(IsusCoreFullNet2017SpaWebCoreModule))]
    public class IsusCoreFullNet2017SpaWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCoreFullNet2017SpaWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017SpaWebHostModule).GetAssembly());
        }
    }
}
