using eTicketData;
using eTicketData.Entities;
using eTicketServices.IServices;
using Microsoft.EntityFrameworkCore;

namespace eTicketServices.Services
{
    public class EventsService : IEventService
    {
        private readonly ApplicationDbContext _context;

        public EventsService(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(Event newevent)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            var result = await _context.Events.ToListAsync();
            return result;
        }

        public Event GetById(int id)
        {
            var result = _context.Events.FirstOrDefault(e => e.EventId == id);
            return result;
        }

        public Event Update(int id, Event newevent)
        {
            throw new NotImplementedException();
        }
    }
}