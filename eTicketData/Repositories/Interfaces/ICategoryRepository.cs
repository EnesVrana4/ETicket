using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Add(Category entity);
        void AddRange(IEnumerable<Category> entities);
        void Update(Category entity);
        void UpdateRange(IEnumerable<Category> entities);
        void Remove(Category entity);
        void RemoveRange(IEnumerable<Category> entities);
        int Count();
        Category Get(int id);
        IEnumerable<Category> GetAll();
    }
}