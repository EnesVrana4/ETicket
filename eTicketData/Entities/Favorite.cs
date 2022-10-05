#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketData.Entities;
public class Favorite
{
    [Key]
    public int FavoriteId { get; set; }

    [Required]
    public int EventId { get; set; }

    [Required]
    public int UserId { get; set; }
    public Category? MyCategory { get; set; }
    public User? UserFavorites { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}