using SharedComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.IServices
{
    internal interface IUserService
    {
        Task<User> GetByIdAsync(int id);
        Task<User> CreateAsync(User orgnaizer);
        Task<User> UpdateAsync(User orgnaizer);
        Task<User> DeleteAsync(int id);
    }
}
