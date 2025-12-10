using BillingSystem.Core.Entities;
using BillingSystem.Core.Interfaces;
using BillingSystem.DAL.UnitsOfWork;
using BillingSystem.Web.Controllers;

namespace BillingSystem.Domain.Services;

public class BillService : IBillService
{
    private readonly IUnitOfWork _unitOfWork;

    public BillService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

	public async Task<IEnumerable<Bill>> GetAll() {
        var bills = await _unitOfWork.BillRepository.GetAllAsync(b => b.Customer, b => b.BillDetails);

        return bills;
	}

	public async Task<IEnumerable<BillDetail>> GetBillDetails(int billId) {
		IEnumerable<Bill> bills = await this.GetAll();

        var bill = bills.FirstOrDefault(b => b.Id == billId);

        if (bill == null) { return new List<BillDetail>(); }

        return bill.BillDetails;
	}

	public async Task<bool> SaveBill(SaveBillDto saveBillDto)
    {
        var customer = await _unitOfWork.CustomerRepository.GetByIdAsync(saveBillDto.CustomerId);

        if (customer == null)
        {
            return false;
        }

        var (details, subtotal, taxes, total) = await GetBillDetail(saveBillDto.Products);

        Bill bill = new()
        {
            CustomerId = customer.Id,
            Date = DateTime.Now,
            BillDetails = details.ToList(),
            Subtotal = subtotal,
            Taxes = taxes,
            Total = total,            
        };

		foreach (var detail in bill.BillDetails) {
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(detail.ProductId);

            if (product != null) { 
			    product.Stock -= detail.Quantity;            
                _unitOfWork.ProductRepository.Update(product);
            }
		}

        await _unitOfWork.BillRepository.CreateAsync(bill);
		await _unitOfWork.SaveAsync();

        return true;
    }

    private async Task<(IEnumerable<BillDetail>, float, float, float)> GetBillDetail(IEnumerable<SaveBillDetailDto> products)
    {
        List<BillDetail> billDetails = new();

        foreach (var product in products)
        {
            var foundProduct = await _unitOfWork.ProductRepository.GetByIdAsync(product.Id);

            BillDetail detail = new()
            {
                ProductId = foundProduct.Id,
                Quantity = product.Quantity,
                Taxes = foundProduct.UnitPrice * foundProduct.TaxRate / 100,
                UnitPrice = foundProduct.UnitPrice,
                ProductDescription = foundProduct.Description,
            };

            billDetails.Add(detail);
        }

        float subtotal = billDetails.Sum(b => b.UnitPrice * b.Quantity);
        float taxes = billDetails.Sum(b => b.Taxes * b.Quantity);
        float Total = subtotal + taxes;

        return (billDetails, subtotal, taxes, Total);
    }

}