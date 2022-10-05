#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketData.Entities;
public class Event
{
    [Key]
    public int EventId { get; set; } 
    
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string Location { get; set; } 

    [Required]
    [MinLength(3)]
    public string Description { get; set; }
    [Required]
    public DateTime Date { get; set; } 
    [Required]
    public int EventCreatorId { get; set; }
    // Navigation property for related User object
    public EventCreator? Creator { get; set; }

    public List<Category> MyCategory { get; set; } = new List<Category>(); 
    public List<Favorite> EventFavorites { get; set; } = new List<Favorite>();

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}