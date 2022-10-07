using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        ICollection<Ticket> GetTickets();

        Ticket GetTicket(int id);

        Ticket UpdateTicket(Ticket ticket);
    }
}