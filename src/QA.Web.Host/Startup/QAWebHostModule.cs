using Abp.Localization.Sources.Resource;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QA.Configuration;

namespace QA.Web.Host.Startup
{
    [DependsOn(
       typeof(QAWebCoreModule))]
    public class QAWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QAWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Localization.Sources.Add(
                new ResourceFileLocalizationSource(
                    "MySource",
                    MyTexts.ResourceManager
                ));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QAWebHostModule).GetAssembly());
        }
    }
}
