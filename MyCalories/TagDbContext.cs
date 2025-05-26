using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class TagDbContext : DbContext
    {
        public DbSet<Tag> Tage { get; set; }
        public DbSet<Zutat> Zutaten { get; set; }

        public TagDbContext() : base("name=MyAppDatabase")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
