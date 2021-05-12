using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class Test
  {
    public static IEnumerable<object[]> Storevalues = new List<object[]>()
  {
      new object[] { new Store{Name = "ChicagoStore"} },
  };

    public static IEnumerable<object[]> Pizzavalues = new List<object[]>()
    {
      new object[] { new Pizza() }
    };
    public static IEnumerable<object[]> Custommervalues = new List<object[]>()
    {
      new object[] { new Customer{Name = "Bao"} },
      new object[] { new Customer{Name = "John"} }
    };

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_ChicagoStore()
    {
      // arrange
      var sut = new Store { Name = "ChicagoStore" };

      // act
      var actual = sut.Name;

      // assert
      Assert.True(actual == "ChicagoStore");
      Assert.True(sut.ToString() == actual);
    }
    [Fact]
    public void Test_Topping()
    {
      var sut = new Topping { Name = "Chicken" };
      var actual = sut.Name;
      Assert.True(actual == "Chicken");
      Assert.True(sut.ToString() == actual);
    }


    public void Test_OrderPrice()
    {
      var sut = new Pizza { Price = 10 };
      var sut2 = new Pizza { Price = 7 };
      var order = new Order();
      order.Pizzas.AddRange(new[] { sut, sut2 });
      order.GetPrice();
      Assert.True(order.Price == (sut.Price + sut2.Price));
    }
    public void Test_PizzaPrice()
    {
      var sut = new Topping { Price = 3 };
      var sut2 = new Topping { Price = 4 };
      var pizza = new Pizza();
      pizza.Toppings.AddRange(new[] { sut, sut2 });
      pizza.GetPrice();
      Assert.True(pizza.Price == (sut.Price + sut2.Price));
    }

    /// <summary>
    /// 
    /// </summary>

    /// <summary>
    /// 
    /// </summary>
    /// <param name="store"></param>
    [Theory]
    [MemberData(nameof(Storevalues))]

    public void Test_StoreName(Store store)
    {
      Assert.NotNull(store.Name);
      Assert.Equal(store.Name, store.ToString());
    }

    [Theory]
    [MemberData(nameof(Pizzavalues))]
    public void Test_Pizza(Pizza pizza)
    {
      Assert.NotNull(pizza.Toppings);
    }
    [Theory]
    [MemberData(nameof(Custommervalues))]
    public void Test_Customer(Customer customer)
    {
      Assert.Equal(customer.Name, customer.ToString());
    }

  }
}
