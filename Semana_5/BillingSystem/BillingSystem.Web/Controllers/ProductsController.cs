using BillingSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Web.Controllers
{
    [Route("productos")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

		public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

		[HttpGet("/")]
		[HttpGet("")]
		// GET: Products
		public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAll());
        }

        [HttpGet("detalles")]
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var product = await _productService.GetById((int)id);

			if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

		[HttpGet("crear")]
		// GET: Products/Create
		public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,UnitPrice,Stock, TaxRate")] Product product)
        {
            if (ModelState.IsValid)
            {
                await _productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

		[HttpGet("editar")]
		// GET: Products/Edit/5
		public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetById((int)id);
            product.TaxRate *= 100;

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("editar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,UnitPrice,Stock,TaxRate")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
					await _productService.Update(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await ProductExists(product.Id) == false)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

		[HttpGet("remover")]
		// GET: Products/Delete/5
		public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }           

			var product = await _productService.GetById((int)id);

			if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

		
		// POST: Products/Delete/5
		[HttpPost("remover"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _productService.GetById(id);
            if (product != null)
            {
				_productService.Remove(id);
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProductExists(int id)
        {
            bool productExists = _productService.GetById(id) != null;

            return productExists;
		}
    }
}
