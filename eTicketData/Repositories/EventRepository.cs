using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;

namespace eTicketWebApp.Repositories
{

    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Event> GetEvents()
        {
            return _context.Events.ToList();
        }

        public Event GetEvent(int id)
        {
            return _context.Events.FirstOrDefault(u => u.EventId == id);
        }

        public void UpdateEvent()
        {
            
            _context.SaveChanges();

        
        }

        public void Add(Event event1)
        {
            _context.Events.Add(event1);
            _context.SaveChanges();
        }

        public void Delete(Event event2)
        {
           _context.Remove(event2);
            _context.SaveChanges();

        }
    }
}