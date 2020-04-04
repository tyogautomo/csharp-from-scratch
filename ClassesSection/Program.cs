using System;

namespace ClassesSection {

  public class Person {
    public string Name;

    public Person(string name) {
      this.Name = name;
    }

    public void IntroduceTo(string to) {
      Console.WriteLine($"Hi, {to}, I'm {Name}.");
    }
  }



  class Program {
    static void Main(string[] args) {

      var person = new Person("John");
      person.IntroduceTo("Yoga");

      var customer = new Customer(1, "John");
      customer.Id = 1;
      customer.Name = "John";

      Console.WriteLine(customer.Id);
      Console.WriteLine(customer.Name);

      var order = new Order();

      customer.Orders.Add(order);
      Console.WriteLine(customer.Orders);

      Calculator.Add(1, 2, 3, 4, 5);

    }
  }
}
