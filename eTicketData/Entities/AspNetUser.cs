using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace eTicketData.Entities;

// Add profile data for application users by adding properties to the AppUser class
public class AspNetUser : IdentityUser
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



    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Ticket> MyTickets { get; set; }
    public List<Favorite> MyFavorites { get; set; }
    public List<Event>? CreatedEvents { get; set; }
}



