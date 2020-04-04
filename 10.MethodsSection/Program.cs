using System;

namespace MethodsSection {

  class Program {

    static void Main(string[] args) {
      // var number = int.Parse("abc");
      int number;
      var result = int.TryParse("abc", out number);
      if (result) {
        Console.WriteLine(number);
      } else {
        Console.WriteLine("Conversion Failed");
      }
    }

    static void UseParams() {
      var calculator = new Calculator();
      Console.WriteLine(calculator.Add(1, 2, 3));
      Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));
      Console.WriteLine(calculator.Add(1, 2, 3, 3, 2, 1));
      Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
    }

    static void UsePoints() {
      try {
        var point = new Point(10, 20);

        point.Move(null);
        Console.WriteLine($"Point is at {point.X}, {point.Y}");

        point.Move(100, 200);
        Console.WriteLine($"Point is at {point.X}, {point.Y}");

      } catch (Exception) {
        Console.WriteLine($"Ada error nih cok.");
      }
    }
  }
}
