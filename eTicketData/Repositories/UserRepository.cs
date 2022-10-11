using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using System.Linq.Expressions;

namespace eTicketData.Repositories
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

        public void Add(AspNetUser entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<AspNetUser> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUser entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<AspNetUser> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(AspNetUser entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<AspNetUser> entities)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AspNetUser> Find(Expression<Func<AspNetUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AspNetUser GetSingleOrDefault(Expression<Func<AspNetUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AspNetUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AspNetUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<AspNetUser> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<AspNetUser> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AspNetUser>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
