using System;

namespace InheritanceSection
{
  public class Car : Vehicle
  {
    public Car(string registrationNumber)
        : base(registrationNumber)
    {
      Console.WriteLine($"Car is being initialized. {registrationNumber}");
    }
  }
}