using System;

namespace myApp {

  public class Person {
    public string firstName;
    public string lastName;
    public int age;

    public void introduce() {
      var outputString = $"Hello my name is {firstName} {lastName}";
      Console.WriteLine(outputString);
    }
  }
}