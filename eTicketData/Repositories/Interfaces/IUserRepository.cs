using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    public interface IUserRepository
    {
        ICollection<AspNetUser> GetUsers();

        AspNetUser GetUser(string id);

        AspNetUser UpdateUser(AspNetUser user);
        void SaveChanges();
    }
}