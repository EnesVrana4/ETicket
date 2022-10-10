using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
        void Add(Event entity);

        void AddRange(IEnumerable<Event> entities);

        void Update(Event entity);

        void UpdateRange(IEnumerable<Event> entities);

        void Remove(Event entity);

        void RemoveRange(IEnumerable<Event> entities);

        int Count();

        Event Get(int id);
        IEnumerable<Event> GetAll();
    }
}