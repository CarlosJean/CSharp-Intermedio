using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BillingSystem.Core.Entities;
using BillingSystem.DAL.Contexts;

namespace BillingSystem.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerService _Customerservice;

		public CustomersController(CustomerService Customerservice)
        {
            _Customerservice = Customerservice;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _Customerservice.GetAll());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var product = await _Customerservice.GetById((int)id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,UnitPrice,Stock")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                await _Customerservice.AddCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _Customerservice.GetById((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,UnitPrice,Stock")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
					await _Customerservice.Update(customer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await CustomerExists(customer.Id) == false)
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }           

			var product = await _Customerservice.GetById((int)id);

			if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _Customerservice.GetById(id);
            if (product != null)
            {
				_Customerservice.Remove(id);
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> CustomerExists(int id)
        {
            bool productExists = _Customerservice.GetById(id) != null;

            return productExists;
		}
    }
}
