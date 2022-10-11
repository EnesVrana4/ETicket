using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace eTicketData.Entities;


public class AspNetUser : IdentityUser ,IAuditableEntity
{
    public AspNetUser()
    {
        MyTickets = new List<Ticket>();
        MyFavorites = new List<Favorite>();
    }

    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string? LastUpdatedBy { get; set; }
    public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;

    public List<Ticket> MyTickets { get; set; }
    public List<Favorite> MyFavorites { get; set; }
    public List<Event>? CreatedEvents { get; set; }
}

public class AspNetRole: IdentityRole
{

}

