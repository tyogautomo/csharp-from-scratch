using System;

namespace FieldsSection {

  class Program {

    static void Main(string[] args) {

      var customer1 = new Customer(1);

      customer1.Orders.Add(new Order());
      customer1.Orders.Add(new Order());

      customer1.Promote();

      Console.WriteLine(customer1.Orders.Count);

    }
  }
}
