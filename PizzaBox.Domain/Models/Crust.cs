using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Crust : AComponent
    {
        public ICollection<Pizza> Pizzas { get; set; }
    }
}
