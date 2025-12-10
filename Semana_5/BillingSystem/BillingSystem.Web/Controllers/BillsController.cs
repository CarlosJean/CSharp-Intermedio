using BillingSystem.Core.Dtos;
using BillingSystem.Core.Entities;
using BillingSystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BillingSystem.Web.Controllers {

	[Route("facturas")]
	public class BillsController : Controller {
		private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IBillService _billService;

        public BillsController(ICustomerService customerService, IProductService productService, IBillService billService) {
			_customerService = customerService;
			_productService = productService;
			_billService = billService;
		}

		[HttpGet("")]
		public async Task<IActionResult> Index() {
			var bills = await _billService.GetAll();
			return View(bills);
		}


		[HttpGet("detalles/{id}")]
		public async Task<IActionResult> Details(int id) {
			var billDetails = await _billService.GetBillDetails(id);
			return View(billDetails);
		}

		[Route("Crear")]
		public IActionResult Create() { 
		
			return View();
		}

		[HttpPost("GetCustomer")]
		public async Task<Customer> GetCustomer(string personalIdentification) {
			return await _customerService.GetByPersonalIdentification(personalIdentification);
		}

		[HttpPost("GetProducts")]
		public async Task<IEnumerable<Product>> GetProducts() {
            return await _productService.GetAllStock();
        }

		[HttpPost("GetProduct")]
		public async Task<BillDetailDto> GetProduct(int productId) {
            var product = await _productService.GetById(productId);

			BillDetailDto billDetail = new()
            {
				Product = product,
				Taxes = product.UnitPrice * product.TaxRate / 100
            };

			return billDetail;
        }

		[HttpPost("Save")]
		public async Task<IActionResult> Save(SaveBillDto request) {            
			
			if (request?.CustomerId == 0) {
				return NotFound(new
                {
                    Message = "Debe indicar un cliente."
                });
			}

			bool isSaved = await _billService.SaveBill(request);

			if (!isSaved) {
				return BadRequest(new { 
					Message = "Ocurrió un error al intentar guardar la factura."
				});
			}

			return Ok(new
            {
                Message = "Factura guardada satisfactoriamente."
            });
        }
	}
}
