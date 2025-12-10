using BillingSystem.Core.Entities;
using BillingSystem.Core.Interfaces;
using BillingSystem.DAL.UnitsOfWork;

namespace BillingSystem.Domain.Services;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;

    public CustomerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task AddCustomer(Customer customer)
    {
        await _unitOfWork.CustomerRepository.CreateAsync(customer);
        await _unitOfWork.SaveAsync();
    }

    public async Task<IEnumerable<Customer>> GetAll()
    {
        var customers = await _unitOfWork.CustomerRepository.GetAllAsync();
        return customers;
    }

    public async Task<Customer> GetById(int id)
    {
        Customer customer = await _unitOfWork.CustomerRepository.GetByIdAsync(id);
        return customer;
    }

    public async Task<bool> Update(Customer customer)
    {
        var existingCustomer = await _unitOfWork.CustomerRepository.GetByIdAsync(customer.Id);

        if (existingCustomer == null) return false; 
        
        // existingCustomer.Name = customer.Name;
        // existingCustomer.PersonalIdentification = customer.PersonalIdentification;
        // existingCustomer.Email = customer.Email;
        _unitOfWork.CustomerRepository.Update(customer);
        await _unitOfWork.SaveAsync();

        return true;        
    }

    public async Task<bool> Remove(int id)
    {
        var existingCustomer = await _unitOfWork.CustomerRepository.GetByIdAsync(id);

        if (existingCustomer == null) return false;

        _unitOfWork.CustomerRepository.Delete(existingCustomer);
        await _unitOfWork.SaveAsync();

        return true;
    }

	public async Task<Customer> GetByPersonalIdentification(string personalIdentification) {
        var customer = this.GetAll().Result.FirstOrDefault(c => c.PersonalIdentification == personalIdentification);

        return customer ?? new Customer();
	}
}