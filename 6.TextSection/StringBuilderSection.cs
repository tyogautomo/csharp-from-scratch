using System;
using System.Text;

namespace TextSection {

  public class StringBuilderSection {

    public static void Go() {
      var builder = new StringBuilder();
      builder
        .Append('-', 10)
        .AppendLine()
        .Append("Header")
        .AppendLine()
        .Append('-', 10)
        .Replace('-', '+')
        .Remove(0, 10)
        .Insert(0, new string('-', 10));
        
      builder[0] = 'w';
      Console.WriteLine(builder);
    }

  }

}