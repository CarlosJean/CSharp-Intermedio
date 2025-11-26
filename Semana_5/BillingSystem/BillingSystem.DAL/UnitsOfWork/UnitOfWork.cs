using BillingSystem.Core.Entities;
using BillingSystem.DAL.Contexts;
using BillingSystem.DAL.Repositories;

namespace BillingSystem.DAL.UnitsOfWork;

public class UnitOfWork : IDisposable
{
    private bool disposed;
    private GenericRepository<Customer>? customerRepository;
    private readonly ApplicationDbContext _context;

    public GenericRepository<Customer> CustomerRepository
    {
        get
        {
            this.customerRepository ??= new GenericRepository<Customer>(_context);
            return customerRepository;
        }
    }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task SaveAsync() {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        this.disposed = true;
    }
}
