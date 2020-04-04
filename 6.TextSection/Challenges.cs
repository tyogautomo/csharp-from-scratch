using System;
using System.Collections.Generic;
using System.Text;

namespace TextSection {

  public class Challenges {

    public static void IsConsecutive() {
      Console.WriteLine("Please input a number separated by hyphen");
      string input = Console.ReadLine();

      string[] splitted = input.Split('-');
      int[] converted = Array.ConvertAll(splitted, el => Convert.ToInt32(el));

      bool flag = true;
      for (int i = 0; i < converted.Length - 1; i++) {
        if (converted[i + 1] != converted[i] + 1) {
          flag = false;
        }
      }

      if (!flag) {
        flag = true;
        for (int i = 0; i < converted.Length - 1; i++) {
          if (converted[i + 1] != converted[i] - 1) {
            flag = false;
          }
        }
      }

      if (flag) {
        Console.WriteLine("consecutive");
      } else {
        Console.WriteLine("not consecutive");
      }
    }

    public static void IsDuplicate() {
      Console.WriteLine("Please input a number separated by hyphen");
      string input = Console.ReadLine();

      string[] splitted = input.Split('-');
      int[] converted = Array.ConvertAll(splitted, el => Convert.ToInt32(el));

      for (var i = 0; i < converted.Length; i++) {
        for (var j = i + 1; j < converted.Length; j++) {
          if (converted[i] == converted[j]) {
            Console.WriteLine("Duplicated number");
            return;
          }
        }
      }

      Console.WriteLine("No duplicate");
    }

    public static void TimeValidation() {
      Console.WriteLine("Input the time in format HH:mm");
      string input = Console.ReadLine();

      string[] separate = input.Split(':');
      int[] converted = Array.ConvertAll(separate, el => Convert.ToInt32(el));

      bool check = true;

      if (converted[0] < 0 || converted[0] > 23 || converted[1] < 0 || converted[1] > 59) {
        check = false;
      }

      if (!check) {
        Console.WriteLine("Invalid time input");
      } else {
        Console.WriteLine($"It's time {input}!!");
      }
    }

    public static void camelCaseConverter() {
      Console.WriteLine("Please input a words separates with space");
      string sentence = Console.ReadLine();

      string[] separate = sentence.Split(" ");

      List<string> formatted = new List<string>();

      foreach (var word in separate) {
        var lower = new StringBuilder(word.ToLower());
        var firstLetter = lower[0].ToString().ToUpper();
        var convertToChar = Convert.ToChar(firstLetter);
        lower[0] = convertToChar;

        formatted.Add(lower.ToString());
      }

      var result = String.Join("", formatted);
      Console.WriteLine(result);
    }

    public static void checkVowels() {
      char[] vowels = new char[5] { 'a', 'i', 'u', 'e', 'o' };

      Console.WriteLine("Please input an english word: ");
      var input = Console.ReadLine();

      int counter = 0;
      foreach (var letter in input) {
        if (Array.Exists(vowels, el => el == letter)) {
          counter++;
        }
      }
      Console.WriteLine($"There is {counter} vowel(s) in the word");
    }

  }

}