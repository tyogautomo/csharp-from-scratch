using System;

namespace ClassesSection {
  public class Calculator {

      public static void Add(params int[] numbers) {
          var counter = 0;
          foreach(var number in numbers) {
              counter += number;
          }
          Console.WriteLine(counter);
      }

  }
}