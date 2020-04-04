using System;

namespace AccessModifier {

  class Program {

    static void Main(string[] args) {

      var person = new Person(new DateTime(1993, 1, 1), "Jl. kampret");
      Console.WriteLine(person.Age);
    }
  }
}
