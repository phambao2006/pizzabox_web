using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
   
    public class CustomerController : Controller
    {
        private readonly PizzaBoxContext _context;
        
        public CustomerController(PizzaBoxContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Customer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetCustomer(Customer customer) 
        {
          var customerorder = _context.Customers
          .Where(c => c.Name == customer.Name)
          .Include(c => c.Orders)
          .ThenInclude(o => o.Pizzas)
          .ThenInclude(p => p.Toppings).FirstOrDefault();

            return View("customer", customerorder);
        }
    }
}
