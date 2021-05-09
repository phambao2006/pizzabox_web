using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBox.Domain.interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
    public class SizeRepository : IRepository<Size>
    {
        private readonly PizzaBoxContext _context;
        public SizeRepository(PizzaBoxContext context) 
        {
            _context = context;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Size entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Size> Select(Func<Size, bool> filter)
        {
            return _context.Sizes.Where(filter);
        }

        public Size Update()
        {
            throw new NotImplementedException();
        }
    }
}
