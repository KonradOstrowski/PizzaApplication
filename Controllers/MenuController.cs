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
    public class MenuController : ControllerBase
    {
        private S15426Context _context;

        public MenuController(S15426Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMenu()
        {
             return Ok(_context.Product.ToList());
            
        }

        [HttpGet("{int:int}")]

         public IActionResult GetMenuPizza(string id)

        {

          var pizza = _context.Product.FirstOrDefault(e => e.Category == id);
          if (pizza == null)
          {

              return NotFound();
          }

          return Ok(pizza);
         }







    }
}