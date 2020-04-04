using System;

namespace AccessModifier {

  public class Person {
    public string Name { get; set; }
    public string Username { get; set; }
    public DateTime Birthdate { get; private set; }

    public Person(DateTime birthdate, string address) {
      this.Birthdate = birthdate;
    }

    public int Age {
      get {
        var timespan = DateTime.Today - Birthdate;
        var years = timespan.Days / 365;
        return years;
      }
    }

  }
}