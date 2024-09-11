using Microsoft.EntityFrameworkCore;
using Pathfinder2E.Configurations;
using Pathfinder2E.Mechanics.Actions;
using System.Reflection;

namespace Pathfinder2E
{
    public class CharacterSheetDbContext : DbContext
    {
        public DbSet<CharacterSheet> CharacterSheets { get; set; }
        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<MyAction> MyActions { get; set; }
        //public DbSet<Feat> Feats { get; set; }
        //public DbSet<Item> Items { get; set; }
        public string DbPath { get; private set; }

        public CharacterSheetDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            string path = Environment.GetFolderPath(folder);
            if (!Directory.Exists($"{path}\\Centuras"))
            {
                path = $"{path}\\Centuras";
                Directory.CreateDirectory(path);
            }
            else
            {
                path = $"{path}\\Centuras";
            }
            DbPath = Path.Combine(path, "CharacterSheetDb1.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  
        }
    }
}