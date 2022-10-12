#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketData.Entities;
public class Category : AuditableEntity
{
    [Key]
    public int CategoryId { get; set; } 
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Number of Tickets")]
    public int NumOfTickets { get; set; }
    [Required]

    public int Price { get; set; }

    public int EventId { get; set; }
    // Navigation property for related User object
    public Event? Events { get; set; }

     public List<Ticket> MyTicket { get; set; } = new List<Ticket>();
}