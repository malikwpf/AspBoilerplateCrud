using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Crud.Authorization;

namespace Crud
{
    [DependsOn(
        typeof(CrudCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CrudApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CrudAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CrudApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
