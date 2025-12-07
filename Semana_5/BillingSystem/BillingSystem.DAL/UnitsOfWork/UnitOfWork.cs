using System.ComponentModel;
using BillingSystem.Core.Entities;
using BillingSystem.DAL.Contexts;
using BillingSystem.DAL.Repositories;

namespace BillingSystem.DAL.UnitsOfWork;

public class UnitOfWork : IDisposable, IUnitOfWork
{
    private bool disposed;
    private GenericRepository<Customer>? customerRepository;
    private GenericRepository<Product> productRepository;
    private GenericRepository<Bill> billRepository;
    private GenericRepository<BillDetail> billDetailRepository;
    private readonly ApplicationDbContext _context;

    public GenericRepository<Customer> CustomerRepository
    {
        get
        {
            this.customerRepository ??= new GenericRepository<Customer>(_context);
            return customerRepository;
        }
    }
    
    public GenericRepository<Product> ProductRepository
    {
        get
        {
            this.productRepository ??= new GenericRepository<Product>(_context);
            return productRepository;
        }
    }
    
    public GenericRepository<Bill> BillRepository
    {
        get
        {
            this.billRepository ??= new GenericRepository<Bill>(_context);
            return billRepository;
        }
    }
    
    // public GenericRepository<BillDetail> BillDetailRepository
    // {
    //     get
    //     {
    //         this.billDetailRepository ??= new GenericRepository<BillDetail>(_context);
    //         return billDetailRepository;
    //     }
    // }

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
