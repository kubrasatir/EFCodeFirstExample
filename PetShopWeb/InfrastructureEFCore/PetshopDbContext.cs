using Microsoft.EntityFrameworkCore;
using PetShopWeb.InfrastructureEFCore.Entities;

namespace PetShopWeb.InfrastructureEFCore
{
    public class PetshopDbContext:DbContext
    {
        public PetshopDbContext(DbContextOptions<PetshopDbContext> options) : base(options)
        { 
        }
        public DbSet<Bird> Bird { get; set; }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<Cat> Cat { get; set; }
        public DbSet<FeedType> FeedType { get; set; }
        public DbSet<AnimalType> AnimalType { get; set; }

    }
}
