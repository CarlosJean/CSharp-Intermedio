using BillingSystem.Core.Dtos;
using BillingSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BillingSystem.Web.Controllers {
	public class BillsController : Controller {
		private readonly CustomerService _customerService;
        private readonly ProductService _productService;
        private readonly BillService _billService;

        public BillsController(CustomerService customerService, ProductService productService, BillService billService) {
			_customerService = customerService;
			_productService = productService;
			_billService = billService;
		}

		public async Task<IActionResult> Index() {
			var bills = await _billService.GetAll();
			return View(bills);
		}

		
		public async Task<IActionResult> Details(int id) {
			var billDetails = await _billService.GetBillDetails(id);
			return View(billDetails);
		}

		
		public IActionResult Create() { 
		
			return View();
		}

		public async Task<Customer> GetCustomer(string personalIdentification) {
			return await _customerService.GetByPersonalIdentification(personalIdentification);
		}

		public async Task<IEnumerable<Product>> GetProducts() {
            return await _productService.GetAllStock();
        }
		
		public async Task<BillDetailDto> GetProduct(int productId) {
            var product = await _productService.GetById(productId);

			BillDetailDto billDetail = new()
            {
				Product = product,
				Taxes = product.UnitPrice * product.TaxRate / 100
            };

			return billDetail;
        }

		public async Task<IActionResult> Save(SaveBillDto request) {            
			
			if (request?.CustomerId == 0) {
				return NotFound(new
                {
                    message = "Debe indicar un cliente."
                });
			}

			bool isSaved = await _billService.SaveBill(request);

			return Ok(new
            {
                message = "Factura guardada satisfactoriamente."
            });
        }
	}
}
