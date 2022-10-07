using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;


namespace eTicketWebApp.Repositories
{

    public class TicketRepository 
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();
        }

        public Ticket GetTicket(int id)
        {
            return _context.Tickets.FirstOrDefault(u => u.TicketId == id);
        }

        public Ticket UpdateTicket(Ticket ticket)
        {
            _context.Update(ticket);
            _context.SaveChanges();

            return ticket;
        }

        
    }
}