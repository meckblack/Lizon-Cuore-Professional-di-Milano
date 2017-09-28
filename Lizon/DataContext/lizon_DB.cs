using Lizon.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lizon.DataContext
{
    public class lizon_DB : DbContext
    {
        public lizon_DB() : base("lizon")
        {
            Database.SetInitializer<lizon_DB>(new Initializer());
        }

        public DbSet<AppUser> appuser { get; set; }
        public DbSet<Role> role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}