using System;
using myApp.Math; //you must import this if you want use another namespace

namespace myApp {
  public enum ShippingMethod { // this is how you make enum
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
  }

  class Program {
    static void Main(string[] args) {
      var john = new Person();
      john.firstName = "John";
      john.lastName = "Smith";
      john.introduce();

      var calculator = new Calculator();
      var result = calculator.add(2, 2);
      Console.WriteLine(result);

      var numbers = new int[3];
      numbers[0] = 1;
      Console.WriteLine(numbers[0]);
      Console.WriteLine(numbers[1]);

      var flags = new bool[2];
      flags[0] = true;
      Console.WriteLine(flags[0]);
      Console.WriteLine(flags[1]);

      var names = new string[2] { "Budi", "Cokro" };
      Console.WriteLine(names[1]);

      var budiName = "Budi";
      var jonoName = "Jono";

      var friends = $@"My friends name are {budiName} and {jonoName}
And many other.";
      Console.WriteLine(friends);

      var method = ShippingMethod.Express;
      Console.WriteLine((int)method);

      var methodName = "Express";
      var choosedMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
      Console.WriteLine(choosedMethod);

      var myAge = 25; // this is how value types work, method didnt change the value of myAge index 0 because different scope
      Program.Increment(myAge);
      Console.WriteLine(myAge);

      var arrOfNumbers = new int[2] { 1, 2 }; // method will change the index of 0 to 100, because array are reference types
      Console.WriteLine(arrOfNumbers[0]);
      Program.elementChanger(arrOfNumbers);
      Console.WriteLine(arrOfNumbers[0]);

      // this is how reference type work in object instance
      var bujank = new Person();
      bujank.age = 10;
      Console.WriteLine(bujank.age);
      Program.makeOld(bujank);
      Program.makeOld(bujank);
      Console.WriteLine(bujank.age);
    }

    public static void Increment(int number) {
      number += 10;
    }

    public static void elementChanger(int[] arr) {
      arr[0] = 100;
    }

    public static void makeOld(Person person) {
      person.age += 10;
    }
  }
}
