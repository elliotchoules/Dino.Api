using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dino.Api.Models.Data.DbContexts
{
    public class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // All of the tables (DbSets) in the UserDbContext class will have the "user" schema. This is helpful as both contexts share the same database.
            modelBuilder.HasDefaultSchema(nameof(User)); 
        }
    }
}
