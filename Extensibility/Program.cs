using System.IO;

namespace Extensibility
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\victor.lino\\Documents\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}