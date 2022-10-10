using eTicketData.Entities;
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
                .AddUserManager<UserManager<AspNetUser>>();
            services.AddScoped<IEventRepository, Repositories.EventRepository>();
            return services;
        }
    }
}
