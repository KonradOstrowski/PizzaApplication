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
    public class EmployeeController : ControllerBase
    {
        private S15426Context _context;

        public EmployeeController(S15426Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_context.Employee.ToList());

        }

        [HttpGet("{id:int}")]

        public IActionResult GetEmployee(int id)

        {

            var order = _context.Employee.FirstOrDefault(e => e.Id == id);
            if (order == null)
            {

                return NotFound();
            }

            return Ok(order);
        }

        [HttpPost]

        public IActionResult Create(Employee newEmp)
        {
            _context.Employee.Add(newEmp);
            _context.SaveChanges();

            return StatusCode(200, newEmp);
        }



        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            var emp = _context.Employee.FirstOrDefault(e => e.Id == id);
            if (emp == null)
            {
                return NotFound();

            }

            _context.Employee.Remove(emp);
            _context.SaveChanges();

            return Ok(emp);
        }



    }
}