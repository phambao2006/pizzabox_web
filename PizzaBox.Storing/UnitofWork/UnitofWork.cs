using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing.UnitofWork
{
    public class UnitofWork
    {
        private readonly PizzaBoxContext _context;
        public OrderRepository Orders { get; set; }
        public CrustRepository Crusts { get; }
        public SizeRepository Sizes { get; }
        public ToppingsRepository Toppings { get; }
        public StoreRepository Stores { get; }

        public UnitofWork(PizzaBoxContext context)
        {
            _context = context;
            Crusts = new CrustRepository(_context);
            Sizes = new SizeRepository(_context);
            Orders = new OrderRepository(_context);
            Toppings = new ToppingsRepository(_context);
            Stores = new StoreRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
