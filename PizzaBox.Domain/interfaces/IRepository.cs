using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Select(Func<T, bool> filter);
        bool Insert(T entry);
        T Update();
        bool Delete();

    }
}
