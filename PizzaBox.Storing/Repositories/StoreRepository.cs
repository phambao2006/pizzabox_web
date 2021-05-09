using PizzaBox.Domain.interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Storing.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private readonly PizzaBoxContext _context;
        public StoreRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Store entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Store> Select(Func<Store, bool> filter)
        {
            return _context.Stores.Where(filter);
        }

        public Store Update()
        {
            throw new NotImplementedException();
        }
    }
}
