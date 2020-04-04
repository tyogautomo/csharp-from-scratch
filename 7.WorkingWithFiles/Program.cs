using System;
using System.IO;

namespace WorkingWithFiles {

  class Program {

    static void Main(string[] args) {

      var path = "../../../../..";
      File.Copy($"{path}/Downloads/tanaman.jpg", $"{path}/Documents/cobol.jpg", true);

      if (File.Exists($"{path}/Documents/cobol.jpg")) {
        Console.WriteLine("Filenya ada anjerrrrr");
        // var content = File.ReadAllText($"{path}/Documents/cobol.jpg");

        var fileInfo = new FileInfo($"{path}/Documents/cobol.jpg");
        Console.WriteLine(fileInfo.Directory);

      }

      File.Delete($"{path}/Documents/cobol.jpg");

      DirectorySection();
    }

    static void DirectorySection() {
      var path = "../../../../..";
      Directory.CreateDirectory("path...");

      var files = Directory.GetFiles($"{path}/Documents", "*.*", SearchOption.TopDirectoryOnly);

      foreach (var file in files) {
        Console.WriteLine(file);
      }
    }
  }
}
