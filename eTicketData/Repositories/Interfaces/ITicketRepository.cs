using eTicketData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eTicketData.Repositories.Interfaces
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        void Add(Ticket entity);
        void AddRange(IEnumerable<Ticket> entities);
        //void Update(Ticket entity);
        //void UpdateRange(IEnumerable<Ticket> entities);
        void Remove(Ticket entity);
        void RemoveRange(IEnumerable<Ticket> entities);
        int Count();
        Ticket Get(int id);
        IEnumerable<Ticket> GetAll();
        IEnumerable<Ticket> GetMyTickets();
    }

   
    
}
