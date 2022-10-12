using eTicketData.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.IServices
{
    public interface IRoleService
    {
        Task<IEnumerable<AspNetRole>> GetRolesAsync();

    }
}
