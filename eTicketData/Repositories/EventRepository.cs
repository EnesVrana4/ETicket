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

        public IEnumerable<Event> GetMyEvents()
        {
         
            // Expression<Func<Event, bool>> isTeenAgerExpr = s => s.IsActive==true;
            var all = _context.Events.
                Where(e=>e.CreatedBy== _context.CurrentUserId  && e.IsActive==true).ToList();
            return all;
        
    }
    }
}