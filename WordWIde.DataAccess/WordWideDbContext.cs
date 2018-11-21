using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WordWide.Model;

namespace WordWIde.DataAccess
{
    public class WordWideDbContext : DbContext
    {
        public WordWideDbContext() : base("WordWideDb")
        {

        }

        public DbSet<Word> Words{ get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        base.OnModelCreating(modelBuilder);
    //        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    //    }
    }
}
