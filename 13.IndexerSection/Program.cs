using System;

namespace IndexerSection {

  class Program {

    static void Main(string[] args) {

      var cookie = new HttpCookies();

      cookie["name"] = "Yoga";
      Console.WriteLine(cookie["name"]);

      cookie["name"] = "Tobis";
      Console.WriteLine(cookie["name"]);


    }
  }
}
