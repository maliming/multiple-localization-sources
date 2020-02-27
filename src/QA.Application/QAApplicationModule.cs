using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QA.Authorization;

namespace QA
{
    [DependsOn(
        typeof(QACoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QAApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QAAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QAApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
