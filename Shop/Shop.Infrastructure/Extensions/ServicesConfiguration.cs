using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Infrastructure.Identity;
using Shop.Infrastructure.Persistence.Data.Identity;
using Shop.Infrastructure.Persistence.Data.INFPort;
using Shop.Infrastructure.Persistence.Data.INFPortObject;

namespace Shop.Infrastructure.Extensions
{
    public static class ServicesConfiguration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddPersistenceContexts(configuration);
            services.AddAuthenticationScheme(configuration);
        }

        public static void AddAuthenticationScheme(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc(o =>
            {
                //Add Authentication to all Controllers by default.
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                o.Filters.Add(new AuthorizeFilter(policy));
            });
        }

        public static void AddPersistenceContexts(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<IdentityContext>(options =>
                    options.UseInMemoryDatabase("IdentityDb"));
                services.AddDbContext<INFPortObjectContext>(options =>
                    options.UseInMemoryDatabase("INFPortObjectDb"));
                services.AddDbContext<INFPortContext>(options =>
                    options.UseInMemoryDatabase("INFPortDb"));
            }
            else
            {
                services.AddDbContext<IdentityContext>(options => options.UseSqlServer(configuration.GetConnectionString("INFPortConnection")));
                services.AddDbContext<INFPortObjectContext>(options => options.UseSqlServer(configuration.GetConnectionString("INFPortObjectConnection")));
                services.AddDbContext<INFPortContext>(options => options.UseSqlServer(configuration.GetConnectionString("INFPortConnection")));
            }
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<IdentityContext>().AddDefaultUI().AddDefaultTokenProviders();
        }
    }
}
