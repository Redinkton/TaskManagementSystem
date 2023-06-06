using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        // The AddPersistence method for registering the database context
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("mydatabase")));
            return services;
        }
        // The AddIdentityConfiguration method to configure Identity options

                //public static IServiceCollection AddMyDependencyGroup(this IServiceCollection services)
                //{
                //    services.AddScoped<>();
                //    services.AddScoped<>();
                //    return services;
                //}
            }
}
