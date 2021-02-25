using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Common.Interfaces;
using Shop.Application.Common.Interfaces.Repositories;
using Shop.Application.Common.Interfaces.Repositories.Common;
using Shop.Application.Common.Interfaces.Repositories.INFPortObject;
using Shop.Infrastructure.Identity;
using Shop.Infrastructure.Persistence.Data.Identity;
using Shop.Infrastructure.Persistence.Data.INFPort;
using Shop.Infrastructure.Persistence.Data.INFPortObject;
using Shop.Infrastructure.Repositories;
using Shop.Infrastructure.Repositories.Common;
using Shop.Infrastructure.Repositories.INFPortObject;

namespace Shop.Infrastructure.Extensions
{
    public static class ServicesConfiguration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddRepository();
            services.AddPersistenceContexts(configuration);
        }
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepositoryAsync.INFPort), typeof(RepositoryAsync.INFPort));
            services.AddTransient(typeof(IRepositoryAsync.INFPortObject), typeof(RepositoryAsync.INFPortObject));
            services.AddTransient<IUnitOfWork.INFPort, UnitOfWork.INFPort>();
            services.AddTransient<IUnitOfWork.INFPortObject, UnitOfWork.INFPortObject>();
            services.AddTransient<ITacitRepository, TacitRepository>();
            services.AddTransient<ICommonRepository, CommonRepository>();
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
            services.AddScoped<IINFPortContext>(provider => provider.GetService<INFPortContext>());
            services.AddScoped<IINFPortObjectContext>(provider => provider.GetService<INFPortObjectContext>());
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<IdentityContext>().AddDefaultUI().AddDefaultTokenProviders();
        }
    }
}
