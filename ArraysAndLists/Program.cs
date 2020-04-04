using System;

namespace ArraysAndLists {
  class Program {
    static void Main(string[] args) {

      // int[] numbers = new int[] { 3, 7, 9, 14, 5, 6 };
      // string[] strings = new string[] { "aha", "ehe", "oho" };

      // //Length
      // Console.WriteLine($"Length: {numbers.Length}");

      // //IndexOf()
      // var index = Array.IndexOf(numbers, 9);
      // Console.WriteLine($"Index of 9 is {index}");

      // //Clear
      // Array.Clear(numbers, 0, 2); // clearing number results to 0
      // Array.Clear(strings, 0, 2); // clearing string or object will results in null

      // Console.WriteLine("Effect of Clear()");
      // foreach (var n in numbers) {
      //   Console.WriteLine(n);
      // }

      // //Copy()
      // int[] anotherArray = new int[3];
      // Array.Copy(numbers, anotherArray, 3);

      // Console.WriteLine("Effect of Copy()");
      // foreach (var item in anotherArray) {
      //   Console.WriteLine(item);
      // }

      // //Sort()
      // Array.Sort(numbers);
      // Console.WriteLine("Effect of Sort()");
      // foreach (var item in numbers) {
      //   Console.WriteLine(item);
      // }

      // //Reverse()
      // Array.Reverse(numbers);
      // Console.WriteLine("Effect of Reverse()");
      // foreach (var item in numbers) {
      //   Console.WriteLine(item);
      // }

      // Console.WriteLine("+++++++++++ THE BEGINNING OF LIST +++++++++++");

      // ListIntroduction.Go();

      // Console.WriteLine("========> Challenge One <========");
      // Exercise.FacebookLikes();
      // Console.WriteLine();

      // Console.WriteLine("========> Challenge Two <========");
      // Exercise.ReverseMyName();
      // Console.WriteLine();

      // Console.WriteLine("========> Challenge Three <========");
      // Exercise.InputDifferentNumber();
      // Console.WriteLine();

      // Console.WriteLine("========> Challenge Four <========");
      // Exercise.UniqueNumbers();
      // Console.WriteLine();

      Console.WriteLine("========> Challenge Five <========");
      Exercise.ThreeLowest();
      Console.WriteLine();
    }

  }
}
