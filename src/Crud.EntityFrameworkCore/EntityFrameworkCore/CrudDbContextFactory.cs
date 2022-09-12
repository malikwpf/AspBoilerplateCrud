using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Crud.Configuration;
using Crud.Web;

namespace Crud.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CrudDbContextFactory : IDesignTimeDbContextFactory<CrudDbContext>
    {
        public CrudDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CrudDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CrudDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CrudConsts.ConnectionStringName));

            return new CrudDbContext(builder.Options);
        }
    }
}
