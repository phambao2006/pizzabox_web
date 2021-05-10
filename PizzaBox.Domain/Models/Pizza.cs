using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Pizza : Entity
    {
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();
        public decimal Price { get; set; }
        public long OrderEntityId { get; set; }
        public long SizeEntityId { get; set; }
        public long CrustEntityId { get; set; }

        public void GetPrice()
        {
            decimal pizzaprice = 4;
            foreach (var topping in Toppings)
            {
                pizzaprice = pizzaprice + topping.Price;
            }

            pizzaprice = pizzaprice + Crust.Price + Size.Price;

            Price = decimal.Round(pizzaprice, 2);
        }
    }
}
