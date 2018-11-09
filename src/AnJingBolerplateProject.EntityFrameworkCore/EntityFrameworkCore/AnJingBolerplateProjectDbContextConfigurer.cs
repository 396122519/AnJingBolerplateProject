using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AnJingBolerplateProject.EntityFrameworkCore
{
    public static class AnJingBolerplateProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AnJingBolerplateProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AnJingBolerplateProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
