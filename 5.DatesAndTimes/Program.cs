using System;

namespace DatesAndTimes {

  class Program {

    static void Main(string[] args) {

      var dateTime = new DateTime(2015, 1, 1);
      var now = DateTime.Now;
      var today = DateTime.Today;

      Console.WriteLine("Hour: " + now.Hour);
      Console.WriteLine("Minute: " + now.Minute);

      var tommorow = now.AddDays(1);
      var yesterday = now.AddDays(-1);

      Console.WriteLine(now.ToLongDateString());
      Console.WriteLine(now.ToShortDateString());
      Console.WriteLine(now.ToLongTimeString());
      Console.WriteLine(now.ToShortTimeString());
      Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

      TheTimeSpan();

    }

    static void TheTimeSpan() {
      //Creating
      var timeSpan = new TimeSpan(1, 2, 3);
      var timeSpan1 = new TimeSpan(1, 0, 0);
      var timeSpan2 = TimeSpan.FromDays(1);

      var start = DateTime.Now;
      var end = DateTime.Now.AddMinutes(2);
      var duration = end - start;

      Console.WriteLine(duration);

      //Properties
      Console.WriteLine("Minutes: " + timeSpan.Minutes);
      Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

      //Add
      Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

      //Substract
      Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

      //ToString
      Console.WriteLine("ToString: " + timeSpan.ToString());

      //Parse
      Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
    }
  }
}
