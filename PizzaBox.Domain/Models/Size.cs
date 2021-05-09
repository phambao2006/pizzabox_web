using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Size : AComponent
    {
        public ICollection<Pizza> Pizzas { get; set; }
    }
}
