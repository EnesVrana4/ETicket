using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace eTicketData.Repositories
{

    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        {
            _context = context;
        }

        public IEnumerable<Ticket> GetMyTickets()
        {
            var all = _context.Favorites.
                Where(e => e.CreatedBy == _context.CurrentUserId && e.IsActive == true).ToList();
            return (IEnumerable<Ticket>)all;
        }

       
    }
}