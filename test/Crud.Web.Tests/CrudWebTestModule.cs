using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Crud.EntityFrameworkCore;
using Crud.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Crud.Web.Tests
{
    [DependsOn(
        typeof(CrudWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CrudWebTestModule : AbpModule
    {
        public CrudWebTestModule(CrudEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CrudWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CrudWebMvcModule).Assembly);
        }
    }
}