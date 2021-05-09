﻿namespace PizzaBox.Domain.Abstracts
{
    public abstract class AComponent : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
