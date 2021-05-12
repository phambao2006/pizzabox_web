using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
    public ICollection<Pizza> Pizzas { get; set; }

    public override string ToString()
    {
      return Name;
    }
  }

}
