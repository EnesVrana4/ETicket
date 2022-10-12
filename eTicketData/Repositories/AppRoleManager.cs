using eTicketData.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.Repositories
{
    public class AppRoleManager : RoleManager<AspNetRole>
    {
        public AppRoleManager(
            IRoleStore<AspNetRole> store, 
            IEnumerable<IRoleValidator<AspNetRole>> roleValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            ILogger<RoleManager<AspNetRole>> logger) 
            : base(store, roleValidators, keyNormalizer, errors, logger)
        {
        }
    }
}
