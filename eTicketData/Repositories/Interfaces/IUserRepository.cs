using eTicketData.Entities;
using eTicketData;
using SharedComponents.ViewModel;

namespace eTicketData.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<AspNetUser>
    {
        ICollection<AspNetUser> GetUsers();
        AspNetUser GetUser(string id);
        AspNetUser UpdateUser(AspNetUser user);
    }
}
