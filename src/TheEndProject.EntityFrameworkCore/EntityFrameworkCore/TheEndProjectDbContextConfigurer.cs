using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TheEndProject.EntityFrameworkCore
{
    public static class TheEndProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TheEndProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TheEndProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
