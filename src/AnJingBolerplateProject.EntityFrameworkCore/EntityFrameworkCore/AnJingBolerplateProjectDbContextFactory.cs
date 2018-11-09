using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AnJingBolerplateProject.Configuration;
using AnJingBolerplateProject.Web;

namespace AnJingBolerplateProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AnJingBolerplateProjectDbContextFactory : IDesignTimeDbContextFactory<AnJingBolerplateProjectDbContext>
    {
        public AnJingBolerplateProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AnJingBolerplateProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AnJingBolerplateProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AnJingBolerplateProjectConsts.ConnectionStringName));

            return new AnJingBolerplateProjectDbContext(builder.Options);
        }
    }
}
