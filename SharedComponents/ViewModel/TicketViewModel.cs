using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.ViewModel
{

    public class TicketBaseViewModel
    {
        public int CategoryId { get; set; }



    }
    public class TicketViewModel : TicketBaseViewModel
    {
        public int TicketId { get; set; }
    }

    public class TicketEditViewModel : TicketBaseViewModel
    {
    }
}