using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{

    public interface IFavoriteRepository : IRepository<Favorite>
    {
        void Add(Favorite entity);
        void AddRange(IEnumerable<Favorite> entities);
        void Update(Favorite entity);
        void UpdateRange(IEnumerable<Favorite> entities);
        void Remove(Favorite entity);
        void RemoveRange(IEnumerable<Favorite> entities);
        int Count();
        Favorite Get(int id);
        IEnumerable<Favorite> GetAll();
    }
}