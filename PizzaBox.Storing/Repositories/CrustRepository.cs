using PizzaBox.Domain.interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Storing.Repositories
{
    public class CrustRepository : IRepository<Crust>
    {
        private readonly PizzaBoxContext _context;

        public CrustRepository(PizzaBoxContext context) 
        {
            _context = context;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Crust entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Crust> Select(Func<Crust, bool> filter)
        {
            return _context.Crusts.Where(filter);
        }

        public Crust Update()
        {
            throw new NotImplementedException();
        }
    }
}
