using System;

namespace AssociationClasses {

  class Program {

    static void Main(string[] args) {
      var text = new Text();
      text.Width = 100;
      text.Copy();

      var dbMigrator = new DbMigrator(new Logger());

      var logger = new Logger();

      var installer = new Installer(logger);

      dbMigrator.Migrate();
      installer.Install();
    }
  }
}
