using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTicketData.Repositories;
using eTicketServices.IServices;
using eTicketServices.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eTicketServices
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddETicketServices(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventsService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            return services;
        }
    }
}
