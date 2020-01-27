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

        [HttpPost]

        public IActionResult Create(Order newOrder)
        {
            _context.Order.Add(newOrder);
            _context.SaveChanges();

            return StatusCode(200, newOrder);
        }


        [HttpDelete("{orderid:int}")]

        public IActionResult Delete(int orderid)
        {
            var order = _context.Order.FirstOrDefault(e => e.OrderId == orderid);
            if (order == null)
            {
                return NotFound();
            }

            _context.Order.Remove(order);
            _context.SaveChanges();

            return Ok(order);
        }




        
    }
}