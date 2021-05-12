using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
  public class Customer : Entity
  {
    public string Name { get; set; }

    public List<Order> Orders { get; set; }
    public override string ToString()
    {
      return Name;
    }
  }
}
