using SharedComponents.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.IServices
{
    public interface ITicketService
    {
            ICollection<TicketViewModel> GetTickets();

            TicketViewModel GetTicket(int id);
            TicketViewModel Add(TicketEditViewModel ticket);
            void AddTicket(int categoryId);
        void Delete(int id);
        

        }
    }

