#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketData.Entities;
public class Favorite : AuditableEntity
{
    [Key]
    public int FavoriteId { get; set; }

    [Required]
    public int EventId { get; set; }

    public Event? Event { get; set; }
    public AspNetUser? AspNetUser { get; set; }
}