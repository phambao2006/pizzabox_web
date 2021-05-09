using PizzaBox.Domain.interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
    public class ToppingsRepository : IRepository<Topping>
    {
        private readonly PizzaBoxContext _context;
        public ToppingsRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Topping entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Topping> Select(Func<Topping, bool> filter)
        {
            return _context.Toppings.Where(filter);
        }

        public Topping Update()
        {
            throw new NotImplementedException();
        }
    }
}
