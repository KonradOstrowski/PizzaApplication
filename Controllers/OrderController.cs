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
    public class OrderController : ControllerBase
    {
        private S15426Context _context;

        public OrderController(S15426Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_context.Order.ToList());

        }

        [HttpGet("{id:int}")]

        public IActionResult GetMenuPizza(int id)

        {

            var order = _context.Order.FirstOrDefault(e => e.OrderId == id);
            if (order == null)
            {

                return NotFound();
            }

            return Ok(order);
        }







    }
}