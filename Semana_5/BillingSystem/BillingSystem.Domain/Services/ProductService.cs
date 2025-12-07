using BillingSystem.Core.Entities;
using BillingSystem.DAL.UnitsOfWork;

namespace BillingSystem.Domain.Services;

public class ProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task AddProduct(Product product)
    {
        await _unitOfWork.ProductRepository.CreateAsync(product);
        await _unitOfWork.SaveAsync();
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = await _unitOfWork.ProductRepository.GetAllAsync();
        return products;
    }

    public async Task<IEnumerable<Product>> GetAllStock()
    {
        var products = await _unitOfWork.ProductRepository.GetAllAsync();
        products = products.Where(p => p.Stock > 0);
        
        return products;
    }

    public async Task<Product> GetById(int id)
    {
        Product product = await _unitOfWork.ProductRepository.GetByIdAsync(id);
        return product;
    }

    public async Task<bool> Update(Product product)
    {
        var existingProduct = await _unitOfWork.ProductRepository.GetByIdAsync(product.Id);

        if (existingProduct == null) return false;

		_unitOfWork.ProductRepository.Update(product);

		// Actualiza solo los campos necesarios
		
		//existingProduct.Description = product.Description;
		//existingProduct.UnitPrice = product.UnitPrice;
		//existingProduct.Stock = product.Stock;

		await _unitOfWork.SaveAsync();
        return true;        
    }

    public async Task<bool> Remove(int id)
    {
        var existingProduct = await _unitOfWork.ProductRepository.GetByIdAsync(id);

        if (existingProduct == null) return false;

        _unitOfWork.ProductRepository.Delete(existingProduct);
        await _unitOfWork.SaveAsync();

        return true;
    }
}