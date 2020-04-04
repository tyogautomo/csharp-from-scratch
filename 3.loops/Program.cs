using System;
using Exercise;

namespace loops {

  class Program {

    static void Main(string[] args) {

      // for (var i = 0; i <= 10; i++) { //increment
      //   if (i % 2 == 0) {
      //     Console.WriteLine(i);
      //   }
      // }

      // for (var i = 10; i >= 1; i--) { // decrement
      //   if (i % 2 == 0) {
      //     Console.WriteLine(i);
      //   }
      // }

      // var name = "John Smith";

      // for (var i = 0; i < name.Length; i++) {
      //   Console.WriteLine(name[i]);
      // }

      // foreach (var element in name) {               // foreach itteration on stirng
      //   Console.WriteLine(element + " foreach");
      // }


      // var numbers = new int[] { 1, 2, 3, 4 };

      // foreach (var number in numbers) {             // foreach itteration on array
      //   Console.WriteLine(number);
      // }

      // var z = 0;

      // while (z <= 10) {
      //   if (z % 2 == 0) {
      //     Console.WriteLine(z);
      //   }
      //   z++;
      // }

      // while (true) {                                // continue on itteration
      //   Console.Write("Type your name: ");
      //   var input = Console.ReadLine();

      //   if (!String.IsNullOrWhiteSpace(input)) {
      //     Console.WriteLine("@Echo: " + input);
      //     continue;
      //   }

      //   break;
      // }

      // //random class
      // var random = new Random();
      // for (var i = 0; i < 10; i++) {
      //   Console.Write((char)('a' + random.Next(0, 26)));
      // }
      // Console.WriteLine();

      // const int passwordLength = 10;
      // var buffer = new char[passwordLength];
      // for (var i = 0; i < passwordLength; i++) {
      //   buffer[i] = (char)('a' + random.Next(0, 26));
      // }

      // var password = new string(buffer);
      // Console.WriteLine(password);

      Console.WriteLine("========================= EXERCICES =========================");

      Console.WriteLine("=================== Exercise 1");
      Console.WriteLine("Please input a number");
      var userInput1 = Console.ReadLine();
      var count = Challenges.ModulusThreeCounter(Int32.Parse(userInput1));
      Console.WriteLine($"The numbers divisible by 3 is {count}");

      Console.WriteLine();
      Console.WriteLine("=================== Exercise 2");
      var challengeTwo = Challenges.SumMyNumber();
      Console.WriteLine(challengeTwo);

      Console.WriteLine();
      Console.WriteLine("=================== Exercise 3");
      Console.WriteLine("Please input a number: ");
      var userInput3 = Console.ReadLine();
      var challengeThree = Challenges.Factorial(userInput3);
      Console.WriteLine(challengeThree);

      Console.WriteLine();
      Console.WriteLine("=================== Exercise 4");
      var challengeFour = Challenges.GuessNumber();
      Console.WriteLine(challengeFour);

      Console.WriteLine();
      Console.WriteLine("=================== Exercise 5");
      Console.WriteLine("Please input a several numbers separated with ', ': ");
      var userInput5 = Console.ReadLine();
      var challengeFive = Challenges.MyMaximumNumbers(userInput5);
      Console.WriteLine($"Your maximum number is {challengeFive}");
    }
  }

}
