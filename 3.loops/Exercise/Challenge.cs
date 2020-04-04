using System;
using System.Linq;

namespace Exercise {

  public class Challenges {

    public static int ModulusThreeCounter(int number) {
      var counter = 0;
      for (var i = 0; i <= number; i++) {
        if (i % 3 == 0) {
          counter++;
        }
      }
      return counter;
    }

    public static string SumMyNumber() {
      var counter = 0;
      while (true) {
        Console.WriteLine("Input a random number: ");
        var userInput = Console.ReadLine();
        if (userInput == "ok") {
          break;
        } else {
          counter += Int32.Parse(userInput);
        }
      }

      return $"Your input summary is {counter}";
    }

    public static string Factorial(string userInput) {
      var parseInput = Int32.Parse(userInput);
      var result = parseInput;

      for (var i = parseInput - 1; i >= 1; i--) {
        result *= i;
      }

      return $"{userInput}! = {result}";

    }

    public static string GuessNumber() {
      var random = new Random();
      var randomNumber = random.Next(0, 11);
      Console.WriteLine(randomNumber);
      var attempt = 1;

      while (attempt < 5) {
        Console.WriteLine("Write a number between 1 and 10: ");
        var parseInput = Int32.Parse(Console.ReadLine());

        if (parseInput == randomNumber) {
          return "You won the game!";
        }
        attempt++;
      }

      return "You lose the game..";
    }

    public static int MyMaximumNumbers(string userInput) {
      string[] splitInput = userInput.Split(", ");
      int[] newArray = splitInput.Select(element => Int32.Parse(element)).ToArray();

      return newArray.Max();
    }
  }

}