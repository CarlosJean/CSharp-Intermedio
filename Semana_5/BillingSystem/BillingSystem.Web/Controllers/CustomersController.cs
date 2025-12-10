using BillingSystem.Core.Entities;
using BillingSystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Web.Controllers
{
	[Route("clientes")]
	public class CustomersController : Controller
    {
		private readonly ICustomerService _customerService;

		public CustomersController(ICustomerService customerService) {
			_customerService = customerService;
		}
		
		// GET: Customers
		public async Task<IActionResult> Index()
        {
			return View(await _customerService.GetAll());
		}

		// GET: Customers/Details/5
		[HttpGet("Detalles")]
        public async Task<IActionResult> Details(int? id)
        {
			if (id == null) {
				return NotFound();
			}

			var product = await _customerService.GetById((int)id);
			if (product == null) {
				return NotFound();
			}

			return View(product);
		}

		// GET: Customers/Create
		[HttpGet("crear")]
		public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PersonalIdentification,Email")] Customer customer)
        {
			if (ModelState.IsValid) {
				await _customerService.AddCustomer(customer);
				return RedirectToAction(nameof(Index));
			}
			return View(customer);
		}

		// GET: Customers/Edit/5
		[HttpGet("editar/{id?}")]
		public async Task<IActionResult> Edit(int? id)
        {
			if (id == null) {
				return NotFound();
			}

			var product = await _customerService.GetById((int)id);
			if (product == null) {
				return NotFound();
			}
			return View(product);
		}

		// POST: Customers/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost("editar")]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PersonalIdentification,Email")] Customer customer)
        {
			if (id != customer.Id) {
				return NotFound();
			}

			if (ModelState.IsValid) {
				try {
					await _customerService.Update(customer);
				} catch (DbUpdateConcurrencyException) {
					if ( await CustomerExists(customer.Id) == false) {
						return NotFound();
					} else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(customer);
		}

		// GET: Customers/Delete/5
		[HttpGet("remover/{id?}")]
		public async Task<IActionResult> Delete(int? id)
        {
			if (id == null) {
				return NotFound();
			}

			var product = await _customerService.GetById((int)id);

			if (product == null) {
				return NotFound();
			}

			return View(product);
		}

        // POST: Customers/Delete/5
        [HttpPost("remover/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
			var product = await _customerService.GetById(id);
			if (product != null) {
				_customerService.Remove(id);
			}
			return RedirectToAction(nameof(Index));
		}

		private async Task<bool> CustomerExists(int id)
        {
			bool productExists = _customerService.GetById(id) != null;

			return productExists;
		}
	}
}
