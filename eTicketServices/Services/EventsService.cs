using eTicketServices.IServices;
using SharedComponents.Models;

namespace eTicketServices.Services
{
    public class EventsService : IEventService
    {
        public void Add(Event eventModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Event GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Event Update(int id, Event eventModel)
        {
            throw new NotImplementedException();
        }
    }
}