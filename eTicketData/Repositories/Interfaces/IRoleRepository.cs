using eTicketData.Entities;
using Microsoft.AspNetCore.Identity;

namespace eTicketData.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<IdentityRole>
    {
        ICollection<AspNetRole> GetRoles();
    }
}


