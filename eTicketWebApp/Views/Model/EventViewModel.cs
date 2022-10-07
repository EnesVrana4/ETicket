using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketWebApp.Views.Model;
public class EventViewModel
{
    public int EventId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int EventCreatorId { get; set; }
}
