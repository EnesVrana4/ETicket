using eTicketData.Entities;
using SharedComponents.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.IServices
{
    public interface IUserService
    {
        ICollection<UserViewModel> GetUsers();
        UserViewModel GetUser(string id);
        UserViewModel UpdateUser(UserViewModel user);

    }
}
