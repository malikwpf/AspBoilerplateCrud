using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFrameworkCore
{
    public static class CrudDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CrudDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CrudDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
