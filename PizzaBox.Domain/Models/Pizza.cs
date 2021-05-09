using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Pizza : Entity
    {
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();
        public long OrderEntityId { get; set; }
        public long SizeEntityId { get; set; }
        public long CrustEntityId { get; set; }

    }
}
