using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using Microsoft.AspNetCore.Http;

namespace eTicketData.Repositories
{

    public class EventRepository :  Repository<Event>, IEventRepository
    {

        public EventRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public Event GetLastCreated()
        {
            return _context.Events.OrderByDescending(e => e.CreatedDate).FirstOrDefault();
        }

        public IEnumerable<Event> GetMyEvents()
        {
         
            // Expression<Func<Event, bool>> isTeenAgerExpr = s => s.IsActive==true;
            var all = _context.Events.
                Where(e=>e.CreatedBy== _context.CurrentUserId  && e.IsActive==true).ToList();
            return all;

        }
        public IEnumerable<Event> SearchByDate(DateTime start, DateTime end)
        {

            var all = _context.Events
                .Where(s => s.Date > start && s.Date < end)
                /*.Where(e =>  e.IsActive == true)*/.ToList();
            return all;

        }

       
        public IEnumerable<Event> Search(string search)
        {

            
            var all = _context.Events.
                Where(e => e.Name!.Contains(search) && e.IsActive).ToList();
            return all;

        }
    }
}