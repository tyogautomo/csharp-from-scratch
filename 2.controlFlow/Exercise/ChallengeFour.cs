using System;

namespace controlFlow.Exercise {

  public class ChallengeFour {

    public int speedLimit;

    public string checkCarSpeed(Car car) {
      string result;

      if (car.CarSpeed <= speedLimit) {
        result = "OK you are safe!";
      } else {
        decimal multiplier = (car.CarSpeed - speedLimit) / 5;
        decimal penalty = Math.Ceiling(multiplier);
        if (penalty > 12) {
          result = "Your license are under arrest";
        } else {
          result = $"You charged for {penalty} dollars";
        }
      }
      return result;
    }

  }

  public class Car {
    private decimal carSpeed;
    public decimal CarSpeed { get => carSpeed; set => carSpeed = value; }
  }

}