using PizzaBox.Domain.interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;

namespace PizzaBox.Storing.Repositories
{
    public class OrderRepository : IRepository<Order>
    {

        public readonly PizzaBoxContext _context;

        public OrderRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Order entry)
        {
            _context.Orders.Add(entry);
            return true;
        }

        public IEnumerable<Order> Select(Func<Order, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Order Update()
        {
            throw new NotImplementedException();
        }
    }
}