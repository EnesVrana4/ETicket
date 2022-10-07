using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    public interface IEventRepository 
    {
        ICollection<Event> GetEvents();

        Event GetEvent(int id);

        void UpdateEvent();

        void Add(Event event1);

        void Delete(Event event2);
       
    }
}