using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TheEndProject.Configuration;
using TheEndProject.Web;

namespace TheEndProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TheEndProjectDbContextFactory : IDesignTimeDbContextFactory<TheEndProjectDbContext>
    {
        public TheEndProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TheEndProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TheEndProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TheEndProjectConsts.ConnectionStringName));

            return new TheEndProjectDbContext(builder.Options);
        }
    }
}
