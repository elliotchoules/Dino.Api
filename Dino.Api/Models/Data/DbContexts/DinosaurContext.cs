using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Dino.Api.Models.Data.DbContexts
{
    // The database context is a class that coordinates Entity Framework functionality for the data model.
    public class DinosaurContext : DbContext
    {
        public DinosaurContext(DbContextOptions<DinosaurContext> options) 
            : base(options)
        {
        }

        // In Entity Framework, an entity set typically corresponds to a database table and an entity corresponds to a row in the table.
        public DbSet<Dinosaur> Dinosaurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dinosaur>().HasData(SeedData());
        }

        private List<Dinosaur> SeedData()
        {
            var dinosaurs = new List<Dinosaur>();
            using (StreamReader reader = new StreamReader(@"dinosaurs.json"))
            {
                string json = reader.ReadToEnd();
                dinosaurs = JsonSerializer.Deserialize<List<Dinosaur>>(json);
            }

            int index = 1;
            foreach (var d in dinosaurs)
            {
                d.Id = index;
                index++;
            }

            return dinosaurs;
        }
    }
}
