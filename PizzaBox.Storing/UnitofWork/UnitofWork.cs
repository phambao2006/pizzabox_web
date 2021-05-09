using PizzaBox.Storing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Storing.UnitofWork
{
    public class UnitofWork
    {
        private readonly PizzaBoxContext _context;
        public CrustRepository Crusts { get; }
        public SizeRepository Sizes { get; }
        public ToppingsRepository Toppings { get; }

        public UnitofWork(PizzaBoxContext context) 
        {
            _context = context;
            Crusts = new CrustRepository(_context);
            Sizes = new SizeRepository(_context);
            Toppings = new ToppingsRepository(_context);
        }

    }
}
