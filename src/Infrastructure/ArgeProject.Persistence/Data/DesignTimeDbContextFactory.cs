using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ArgeProject.Persistence.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ArgeDbContext>
    {
        public ArgeDbContext CreateDbContext(string[] args)
        {
            // Ortamı belirlemek için environment değişkeni kontrol edilir.
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Test";

            // ConfigurationBuilder kullanarak appsettings dosyasını okunur.
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../API/ArgeProject.MainApi"))
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
            .Build();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<ArgeDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            dbContextOptionsBuilder.UseNpgsql(connectionString);

            return new ArgeDbContext(dbContextOptionsBuilder.Options, null);
        }
    }
}
