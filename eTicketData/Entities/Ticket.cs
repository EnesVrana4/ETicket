#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketData.Entities;
public class Ticket
{
    [Key]
    public int TicketId { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    public int UserId { get; set; }
    public Category? MyCategory { get; set; }
    public User? Buyer { get; set; }

    public bool Buyed { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}