using BillingSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.DAL.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Bill> Bills { get; set; }
    public DbSet<BillDetail> BillDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()            
            .HasIndex(p => p.PersonalIdentification)
            .IsUnique();
        
        modelBuilder.Entity<Customer>()            
            .Property(c => c.PersonalIdentification)
            .HasMaxLength(15);
        
        modelBuilder.Entity<Product>()
            .Property(p => p.Stock)
            .HasDefaultValue(0);
    }
}
