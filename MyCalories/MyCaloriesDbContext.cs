using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyCalories
{
    public class MyCaloriesDbContext : DbContext
    {

        public MyCaloriesDbContext() : base("name=MyAppDatabase")
        {

        }
        public DbSet<Zutat> Zutaten { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Gericht> Gerichts { get; set; }
        public DbSet<Soll> Solls { get; set; }
        public DbSet<GerichtZutat> GerichtZutats { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tag>()
            .HasRequired(t => t.Zutat)
            .WithMany(z => z.Tags)
            .HasForeignKey(t => t.ZutatId);

            modelBuilder.Entity<GerichtZutat>()
            .HasKey(gz => new { gz.GerichtZutatId });  

            modelBuilder.Entity<GerichtZutat>()
            .HasRequired(gz => gz.Gericht)
            .WithMany(g => g.GerichtZutats)
            .HasForeignKey(gz => gz.GerichtId);

            modelBuilder.Entity<GerichtZutat>()
           .HasRequired(gz => gz.Zutat)
           .WithMany(z => z.GerichtZutats)
           .HasForeignKey(gz => gz.ZutatId);
        }
    }
}
