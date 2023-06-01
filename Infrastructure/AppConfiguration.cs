using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class AppConfiguration
    {
        // The AddPersistence method for registering the database context
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("mydatabase")));
            return services;
        }
        // The AddIdentityConfiguration method to configure Identity options
        public static void AddIdentityConfiguration(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

            //    options.LoginPath = "/Identity/Account/Login";
            //    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            //    options.SlidingExpiration = true;
            //});
        }

                //public static IServiceCollection AddMyDependencyGroup(this IServiceCollection services)
                //{
                //    services.AddScoped<>();
                //    services.AddScoped<>();
                //    return services;
                //}
            }
}
