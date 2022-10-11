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

                .AddEntityFrameworkStores<ApplicationDbContext>()
                //.AddRoles<IdentityRole>()
                .AddUserManager<UserManager<AspNetUser>>();
            services.AddScoped<IEventRepository,EventRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();

            return services;
        }
    }
}

