using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class ThankYouController : Controller
    {
        private readonly PizzaBoxContext _context;
        private readonly IHttpContextAccessor _accessor;
        public ThankYouController(PizzaBoxContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult ThankYou()
        {
            var orderjson = _accessor.HttpContext.Session.GetString("order");
            var neworder = JsonConvert.DeserializeObject<Order>(orderjson);

            _context.Orders.Add(neworder);
            _context.SaveChanges();
            return View();
        }
    }
}
