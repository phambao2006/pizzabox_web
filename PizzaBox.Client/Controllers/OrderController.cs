using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.UnitofWork;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly UnitofWork _unitofwork;
        private readonly PizzaBoxContext _context;
        private readonly IHttpContextAccessor _accessor;
        public OrderController(UnitofWork unitofwork, PizzaBoxContext context, IHttpContextAccessor accessor)
        {
            _unitofwork = unitofwork;
            _context = context;
            _accessor = accessor;
        }

        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public IActionResult Order(OrderMVC order)
        {
            if (ModelState.IsValid)
            {
                var crust = _unitofwork.Crusts.Select(c => c.Name == order.SelectedCrust).FirstOrDefault();
                var size = _unitofwork.Sizes.Select(c => c.Name == order.SelectedSize).FirstOrDefault();
                var toppings = new List<Topping>();
                foreach (var t in order.SelectedToppings)
                {
                    toppings.Add(_unitofwork.Toppings.Select(topping => topping.Name == t).FirstOrDefault());
                }
                var pizza = new Pizza { Crust = crust, Size = size, Toppings = toppings };

                var neworder = new Order();

                if (_accessor.HttpContext.Session.GetString("order") == null)
                {
                   
                    neworder.Customer = new Customer { Name = order.CustomerName };

                    neworder.Store = _unitofwork.Stores.Select(s => s.Name == order.SelectedStore).FirstOrDefault();

                    neworder.Pizzas.Add(pizza);

                    _accessor.HttpContext.Session.SetString("order", JsonConvert.SerializeObject(neworder));
                }
                else 
                {
                    var orderjson = _accessor.HttpContext.Session.GetString("order");

                    neworder = JsonConvert.DeserializeObject<Order>(orderjson);

                    neworder.Pizzas.Add(pizza);
                }
                




              //  _context.Orders.Add(neworder);
               // _context.SaveChanges();

              return View(neworder);
            }
            else
            {
                order.Load(_unitofwork);
                return View("../home/index", order);
            }
        }
    }
}