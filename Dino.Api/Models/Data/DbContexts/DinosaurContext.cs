using Microsoft.EntityFrameworkCore;

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
    }
}
