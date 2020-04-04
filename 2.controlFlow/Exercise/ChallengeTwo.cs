using System;
using System.Linq;

namespace controlFlow.Exercise {

  public class ChallengeTwo {

    public string firstNumber;
    public string secondNumber;

    public int compareTwoNumbers() {
      int[] arrOfNumbers = new int[2];
      arrOfNumbers[0] = Int32.Parse(firstNumber);
      arrOfNumbers[1] = Int32.Parse(secondNumber);

      return arrOfNumbers.Max();
    }

  }

}