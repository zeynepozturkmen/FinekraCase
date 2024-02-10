using FinekraCase.Application;
using FinekraCase.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinekraCase.Infrastructure
{
    public static class DependencyInjection
    {
        private static void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            services.AddDbContext<FinekraDbContext>(options => options.UseSqlServer(connectionString, optionBuilder =>
                                                                                 optionBuilder.MigrationsAssembly("FinekraCase.Infrastructure")),
            ServiceLifetime.Singleton);

            using (var scope = services.AddDbContext<FinekraDbContext>()
           .BuildServiceProvider().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<FinekraDbContext>();

                // Apply pending migrations
                dbContext.Database.Migrate();
            }
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                           IConfiguration configuration)
        {
            ConfigureDatabase(services, configuration);
            ConfigureServices(services);
            return services;
        }

        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped(typeof(IGenericRepository<>), typeof(Repository<>));

        }

    }
}

