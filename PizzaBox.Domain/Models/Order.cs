using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public Store Store { get; set; }
    public Customer Customer { get; set; }
    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

    public decimal Price { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public void GetPrice()
    {
      foreach (var pizza in Pizzas)
      {
        Price = Price + pizza.Price;
      }
    }
  }
}
