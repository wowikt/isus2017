using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Isus2017CoreSpa.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Isus2017CoreSpa.Web.Host.Startup
{
    [DependsOn(
       typeof(Isus2017CoreSpaWebCoreModule))]
    public class Isus2017CoreSpaWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Isus2017CoreSpaWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Isus2017CoreSpaWebHostModule).GetAssembly());
        }
    }
}
