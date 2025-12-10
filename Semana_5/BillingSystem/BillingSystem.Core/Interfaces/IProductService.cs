using BillingSystem.Core.Entities;

namespace BillingSystem.Web.Controllers {
	public interface IProductService {
		Task AddProduct(Product product);
		Task<IEnumerable<Product>> GetAll();
		Task<IEnumerable<Product>> GetAllStock();
		Task<Product> GetById(int id);
		Task<bool> Update(Product product);
		Task<bool> Remove(int id);
	}
}