using BillingSystem.Core.Entities;

namespace BillingSystem.Core.Interfaces {
	public interface ICustomerService {
		Task AddCustomer(Customer customer);
		Task<IEnumerable<Customer>> GetAll();
		Task<Customer> GetById(int id);
		Task<bool> Update(Customer customer);
		Task<bool> Remove(int id);
		Task<Customer> GetByPersonalIdentification(string personalIdentification);
	}
}