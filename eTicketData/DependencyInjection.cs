using eTicketData.Entities;
using eTicketData.Repositories;
using eTicketData.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace eTicketData
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddETicketData(this IServiceCollection services) {

            services.AddDefaultIdentity<AspNetUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddUserManager<UserManager<AspNetUser>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IEventRepository,EventRepository>();
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();


            return services;
        }
    }
}

