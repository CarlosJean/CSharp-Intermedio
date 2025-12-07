using BillingSystem.Core.Entities;
using BillingSystem.DAL.Repositories;

namespace BillingSystem.DAL.UnitsOfWork;

public interface IUnitOfWork : IDisposable
{
    GenericRepository<Customer> CustomerRepository { get; }
    GenericRepository<Product> ProductRepository { get; }
    GenericRepository<Bill> BillRepository { get; }
    Task SaveAsync();
}
