using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;

namespace eTicketWebApp.Repositories
{

    public class UserRepository : IUserRepository
        {
            private readonly ApplicationDbContext _context;

            public UserRepository(ApplicationDbContext context)
            {
                _context = context;
          
        }

            public ICollection<AspNetUser> GetUsers()
            {
                return _context.Users.ToList();
            }

            public AspNetUser GetUser(string id)
            {
                return _context.Users.FirstOrDefault(u => u.Id == id);
            }

            public AspNetUser UpdateUser(AspNetUser user)
            {
                _context.Update(user);
                _context.SaveChanges();

                return user;
            }

        //AspNetUser IUserRepository.GetUser(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public AspNetUser UpdateAspNetUser(AspNetUser user)
        //{
        //    throw new NotImplementedException();
        //}
    }
    }