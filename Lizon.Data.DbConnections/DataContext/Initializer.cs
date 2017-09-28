using System.Data.Entity;

namespace Lizon.Data.DbConnections.DataContext
{
    public class Initializer : CreateDatabaseIfNotExists<lizon_DB>
        {
            protected override void Seed(lizon_DB context)
            {
                 base.Seed(context);
            }
        }
}