using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Order : Entity
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}
