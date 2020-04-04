using System;
using System.Collections.Generic;

namespace ArraysAndLists {

  public class ListIntroduction {
    public static void Go() {

      var numbers = new List<int>() { 1, 2, 3, 4 };

      // Add()
      Console.WriteLine("Add()");
      numbers.Add(1);

      //AddRange()
      Console.WriteLine("AddRange()");
      numbers.AddRange(new int[] { 5, 6, 7 });

      foreach (var number in numbers) {
        Console.WriteLine(number);
      }

      //IndexOf()
      Console.WriteLine("IndexOf()");
      Console.WriteLine(numbers.IndexOf(1));

      //LastIndexOf()
      Console.WriteLine("LastIndexOf()");
      Console.WriteLine(numbers.LastIndexOf(1));

      //Count
      Console.WriteLine("Count()");
      Console.WriteLine(numbers.Count);

      //Remove()
      Console.WriteLine("Remove()");
      for (var i = 0; i < numbers.Count; i++) {
        if (numbers[i] == 1) {
          numbers.Remove(numbers[i]);
        }
      }

      foreach (var number in numbers) {
        Console.WriteLine(number);
      }

      //Clear()
      Console.WriteLine("Clear()");
      numbers.Clear();
      Console.WriteLine(numbers.Count);

    }
  }

}