using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTicketData.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace eTicketData;

public class ApplicationDbContext : IdentityDbContext<AspNetUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    Microsoft.AspNetCore.Http.HttpContext _httpContext { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public string CurrentUserId { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
    public override int SaveChanges()
    {
        UpdateAuditEntities();
        return base.SaveChanges();
    }


    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        //UpdateAuditEntities();
        //SaveAuditTrail();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        UpdateAuditEntities();
        return base.SaveChangesAsync(cancellationToken);
    }


    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
    {
        UpdateAuditEntities();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }


    private void UpdateAuditEntities()
    {
        var modifiedEntries = ChangeTracker.Entries()
           .Where(x => x.Entity is AuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));


        foreach (var entry in modifiedEntries)
        {
            var entity = (AuditableEntity)entry.Entity;
            DateTime now = DateTime.Now;
            if (entry.State == EntityState.Added)
            {
                entity.IsActive = true;

                if (entity.CreatedDate.Equals(DateTime.MinValue))
                    entity.CreatedDate = now;
                if (CurrentUserId != null)
                    entity.CreatedBy = CurrentUserId;
                else
                    entity.CreatedBy = "";
            }
            else if (entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entity.IsActive = false;
                base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            }
            else
            {
                entity.IsActive = true;
                base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            }

            entity.LastUpdatedDate = now;
            if (CurrentUserId != null)
                entity.LastUpdatedBy = CurrentUserId;
            else
                entity.LastUpdatedBy = "";
        }
    }

}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AspNetUser>
{
    public void Configure(EntityTypeBuilder<AspNetUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}
