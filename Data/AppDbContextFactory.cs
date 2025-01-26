/* 20. Create a Design-Time Factory (for Migrations & Tools)
Since you're running into this issue while running migrations, 
EF Core tools might not be able to resolve dependencies from DI (dependency injection). 
To resolve this, create a DbContextFactory for design-time support:

9. When to Use This Factory?
If your AppDbcontext constructor requires parameters (such as connection strings), EF Core commands will fail without this factory.
If your app structure separates the web API and the data layer into different projects.
If you encounter runtime errors like:
"Unable to create an instance of 'AppDbcontext'"
 --> 21 AppDbinitializer
*/

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ETicketsApplication.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbcontext>
    {
        public AppDbcontext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbcontext>();
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbcontext(optionsBuilder.Options);
        }
    }
}
