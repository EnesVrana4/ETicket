using SharedComponents.Models;

namespace eTicketServices.IServices
{
    public interface IEventService
    {

        Task<IEnumerable<Event>> GetAll();

        Event GetById(int id);
        void Add(Event eventModel);
        Event Update(int id, Event eventModel);
        void Delete(int id);


    }

}
