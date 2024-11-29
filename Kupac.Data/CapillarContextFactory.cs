using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Kupac.DbContexts
{
    public class CapillarContextFactory : IDesignTimeDbContextFactory<CapillarContext>
    {
        public CapillarContext CreateDbContext(string[] args)
        {
            try
            {
                // Konfiguráció betöltése az appsettings.json-ből
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("CapillarContext");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("Kapcsolati string nem található az appsettings.json fájlban.");
                }

                var optionsBuilder = new DbContextOptionsBuilder<CapillarContext>();
                optionsBuilder.UseSqlServer(connectionString);

                return new CapillarContext(optionsBuilder.Options);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba a CapillarContext létrehozásakor: {ex.Message}");
                throw;
            }
        }

    }
}
