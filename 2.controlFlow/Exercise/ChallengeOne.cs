using System;

namespace controlFlow.Exercise {

  public class ChallengeOne {

    public string number;

    public string checkInput(string number) {
      int inputNumber = Int32.Parse(number);
      string result = (inputNumber >= 1 && inputNumber <= 10) ? "Valid" : "Invalid";
      return result;
    }

  }
}