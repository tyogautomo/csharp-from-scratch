using System;
using controlFlow.Exercise;

namespace controlFlow {

  class Program {
    static void Main(string[] args) {
      Console.WriteLine("============ CHALLENGE ONE =============="); // check if the input value is between range 1-10
      ChallengeOne challengeOne = new ChallengeOne();
      Console.WriteLine(">>>> PLEASE INPUT A NUMBER <<<<");
      challengeOne.number = Console.ReadLine();

      string result = challengeOne.checkInput(challengeOne.number);
      Console.WriteLine(result);

      Console.WriteLine("");
      Console.WriteLine("============ CHALLENGE TWO =============="); // check the biggest value betweeb two numbers
      ChallengeTwo challengeTwo = new ChallengeTwo();
      Console.WriteLine(">>>> PLEASE INPUT THE FIRST NUMBER <<<<");
      challengeTwo.firstNumber = Console.ReadLine();
      Console.WriteLine(">>>> PLEASE INPUT THE SECOND NUMBER <<<<");
      challengeTwo.secondNumber = Console.ReadLine();

      int result2 = challengeTwo.compareTwoNumbers();
      Console.WriteLine($"{result2} is the highest number");

      Console.WriteLine("");
      Console.WriteLine("============ CHALLENGE THREE =============="); // check the image size category
      challengeThree challengeThree = new challengeThree();
      Console.WriteLine(">>>> PLEASE INPUT THE WIDTH <<<<");
      challengeThree.width = Int32.Parse(Console.ReadLine());

      Console.WriteLine(">>>> PLEASE INPUT THE HEIGHT <<<<");
      challengeThree.height = Int32.Parse(Console.ReadLine());

      string result3 = challengeThree.checkImageCategory();
      Console.WriteLine($"The image category is {result3}");

      Console.WriteLine("");
      Console.WriteLine("============ CHALLENGE FOUR =============="); // check the car speed limit
      ChallengeFour challengeFour = new ChallengeFour();
      Car avanza = new Car();

      Console.WriteLine(">>>> PLEASE INPUT THE SPEED LIMIT <<<<");
      challengeFour.speedLimit = Int32.Parse(Console.ReadLine());

      Console.WriteLine(">>>> PLEASE INPUT THE CAR SPEED <<<<");
      avanza.CarSpeed = Int32.Parse(Console.ReadLine());

      string result4 = challengeFour.checkCarSpeed(avanza);

      Console.WriteLine(result4);

    }

  }
}
