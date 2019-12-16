using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;

namespace PizzaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private S15426Context _context;

        public CustomerController(S15426Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_context.Customer.ToList());

        }

        [HttpGet("{id:int}")]

        public IActionResult GetCustomer(int id)

        {

            var order = _context.Customer.FirstOrDefault(e => e.Id == id);
            if (order == null)
            {

                return NotFound();
            }

            return Ok(order);
        }






    }
}