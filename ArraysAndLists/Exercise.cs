using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists {

  public class Exercise {

    public static void FacebookLikes() {
      List<string> friends = new List<string>();
      while (true) {
        Console.WriteLine("Friend name: ");
        string name = Console.ReadLine();

        if (!String.IsNullOrWhiteSpace(name)) {
          friends.Add(name);
        } else {
          break;
        }
      }

      if (friends.Count == 1) {
        Console.WriteLine($"{friends[0]} likes your post");
      } else
      if (friends.Count == 2) {
        Console.WriteLine($"{friends[0]} and {friends[1]} like your post");
      } else
      if (friends.Count > 2) {
        Console.WriteLine($"{friends[0]}, {friends[1]} and {friends.Count - 2} others like your post");
      } else {
        Console.WriteLine();
      }
    }

    public static void ReverseMyName() {
      Console.WriteLine("Your name: ");
      string name = Console.ReadLine();
      var arrName = name.ToCharArray();

      Array.Reverse(arrName);
      string reversedName = string.Join("", arrName);

      Console.WriteLine(reversedName);
    }

    public static void InputDifferentNumber() {
      List<string> numbers = new List<string>();

      for (var i = 0; i < 5; i++) {
        var input = Console.ReadLine();

        if (!numbers.Contains(input)) {
          numbers.Add(input);
        } else {
          Console.WriteLine("number already on list, please use another number");
          i--;
        }
      }

      numbers.Sort();
      foreach (var number in numbers) {
        Console.Write($"{number} ");
      }
    }

    public static void UniqueNumbers() {
      List<string> numbers = new List<string>();

      while (true) {
        Console.WriteLine("Please enter random number");
        string input = Console.ReadLine();

        if (input == "quit" || String.IsNullOrWhiteSpace(input)) {
          break;
        } else if (!String.IsNullOrWhiteSpace(input)) {
          if (!numbers.Contains(input)) {
            numbers.Add(input);
          }
        }
      }

      foreach (var number in numbers) {
        Console.Write($"{number} ");
      }
    }

    public static void ThreeLowest() {
      while (true) {
        Console.WriteLine("Input at least 5 numbers separated with coma (,)");
        var input = Console.ReadLine();
        var splitted = input.Split(",");
        int[] convertedInput = splitted.Select(el => Int32.Parse(el)).ToArray();

        if (convertedInput.Length < 5) {
          Console.WriteLine("[Invalid] The input numbers less than 5, RETRY? (y/n)");
          var answer = Console.ReadLine();

          if (answer == "y") {
            continue;
          } else if (answer == "n") {
            return;
          }
        } else {
          Array.Sort(convertedInput);
          var threeLowest = convertedInput.Take(3);
          foreach (var item in threeLowest) {
            Console.WriteLine(item);
          }
          break;
        }
      }

    }

  }

}
