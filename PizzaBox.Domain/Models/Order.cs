using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    public class Order : Entity
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}
