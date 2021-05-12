using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Controller
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

        [ValidateAntiForgeryToken]
        [HttpPost]
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

                pizza.GetPrice();

                var neworder = new Order();

                if (_accessor.HttpContext.Session.GetString("order") == null)
                {
                    var tempcustomer = _context.Customers.FirstOrDefault(c => c.Name == order.CustomerName);
                    if (tempcustomer != null)
                    {
                        neworder.Customer = tempcustomer;
                    }
                    else
                    {
                        neworder.Customer = new Customer { Name = order.CustomerName };
                    }

                    neworder.Store = _unitofwork.Stores.Select(s => s.Name == order.SelectedStore).FirstOrDefault();

                }
                else
                {
                    var orderjson = _accessor.HttpContext.Session.GetString("order");

                    neworder = JsonConvert.DeserializeObject<Order>(orderjson);
                }

                neworder.Pizzas.Add(pizza);

                JsonConvert.SerializeObject(neworder);
                _accessor.HttpContext.Session.SetString("order", JsonConvert.SerializeObject(neworder));

                return RedirectToAction("GetOrder");
            }
            else
            {
                order.Load(_unitofwork);
                return View("../home/index", order);
            }
        }
        [HttpGet]
        public IActionResult ThankYou()
        {
           var orderjson = _accessor.HttpContext.Session.GetString("order");

           var neworder = JsonConvert.DeserializeObject<Order>(orderjson);


            /*  foreach (var pizza in neworder.Pizzas)
              {
                  _context.ChangeTracker.TrackGraph(
                      neworder, node =>
                      {
                          var keyValue = node.Entry.Property("EntityID").CurrentValue;
                          var entityType = node.Entry.Metadata;

                          var existingEntity = node.Entry.Context.ChangeTracker.Entries()
                              .FirstOrDefault(
                                  e => Equals(e.Metadata, entityType)
                                       && Equals(e.Property("EntityID").CurrentValue, keyValue));

                          if (existingEntity == null)
                          {
                              Console.WriteLine($"Tracking {entityType.DisplayName()} entity with key value {keyValue}");

                              node.Entry.State = EntityState.Modified;
                          }
                          else
                          {
                              Console.WriteLine($"Discarding duplicate {entityType.DisplayName()} entity with key value {keyValue}");
                          }
                      });
              }*/
            _context.Attach(neworder);

            _context.SaveChanges();
            _accessor.HttpContext.Session.Remove("order");
           return View();
        }

        public IActionResult GetOrder()
        {
            var orderjson = _accessor.HttpContext.Session.GetString("order");
            var neworder = JsonConvert.DeserializeObject<Order>(orderjson);
            return View("Order", neworder);
        }
    }
}