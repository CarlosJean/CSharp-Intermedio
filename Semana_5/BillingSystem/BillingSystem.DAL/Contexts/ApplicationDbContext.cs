using BillingSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.DAL.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Customer> Customers { get; set; }
}