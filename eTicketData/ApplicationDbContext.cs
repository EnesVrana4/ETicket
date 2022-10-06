using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTicketData.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eTicketData;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }


    public DbSet<User> Users { get; set; }

    // public DbSet<EventCreator> EventCreators { get; set; } 

    public DbSet<Event> Events { get; set; }
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Favorite> Favorites { get; set; }


}
