using BillingSystem.Core.Entities;
using BillingSystem.DAL.UnitsOfWork;
using BillingSystem.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Customer customer) {           

            await _customerService.AddCustomer(customer);

            return Ok(new
            {
                message = "Cliente creado satisfactoriamente."
            });
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {            
            var customers = await _customerService.GetAll();

            return Ok(new
            {
                data = customers
            });
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            
            var customer = await _customerService.GetById(id);

            return Ok(customer);
        }
        
        [HttpPut]
        public async Task<ActionResult> Update(Customer updatedCustomer)
        {            
            bool isUpdated = await _customerService.Update(updatedCustomer);

            if(!isUpdated)
            {                
                return NotFound(new
                {
                    Message = "El cliente no fue encontrado."
                });
            }

            return Ok(new
            {
                Message = "Cliente actualizado satisfactoriamente."
            });
        }
     
        [HttpDelete("/{id}")]
        public async Task<ActionResult> Delete(int id)
        {            
            bool isDeleted = await _customerService.Remove(id);

            if(!isDeleted)
            {                
                return NotFound(new
                {
                    Message = "El cliente no fue encontrado."
                });
            }

            return Ok(new
            {
                Message = "Cliente removido satisfactoriamente."
            });
        }
    }
}
