using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EFCore.Persistence
{
    public class DefaultContextFactory : IDesignTimeDbContextFactory<DefaultContext>
    {
        public DefaultContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();
            var configuration = configurationBuilder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Db");
            var optionsBuilder = new DbContextOptionsBuilder<DefaultContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new DefaultContext(optionsBuilder.Options);
        }
    }
}
