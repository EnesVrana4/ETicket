
using eTicketData.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eTicketWebApp.Models
{
    public class EditUserViewModel
    {
        public AspNetUser User { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
