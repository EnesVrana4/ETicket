using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace eTicketData.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(IdentityRole entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<IdentityRole> entities)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentityRole> Find(Expression<Func<IdentityRole, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IdentityRole Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentityRole> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentityRole>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<IdentityRole> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityRole> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<AspNetRole> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public IdentityRole GetSingleOrDefault(Expression<Func<IdentityRole, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(IdentityRole entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<IdentityRole> entities)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(IdentityRole entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<IdentityRole> entities)
        {
            throw new NotImplementedException();
        }
    }
}

