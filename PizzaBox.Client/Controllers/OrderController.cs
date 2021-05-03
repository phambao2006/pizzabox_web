using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.UnitofWork;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Controller
    {
        private readonly UnitofWork _unitofwork;
        private readonly PizzaBoxContext _context;
        public OrderController(UnitofWork unitofwork, PizzaBoxContext context)
        {
            _unitofwork = unitofwork;
            _context = context;
        }

        [ValidateAntiForgeryToken]
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

                neworder.Pizzas.Add(pizza);

                _context.Orders.Add(neworder);
                _context.SaveChanges();

                return View(pizza);
            }
            else 
            {
                order.Load(_unitofwork);
                return View("../home/index", order);
            }
        }
    }
}