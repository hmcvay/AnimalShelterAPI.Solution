using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext>options)
      : base (options)
    {

    }
    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Species = "Cat", Name = "Matilda", Age = 7, Sex = "F", Description = "Bites ankles to beg for food" },
          new Animal { AnimalId = 2, Species = "Cat", Name = "Caserole", Age = 1, Sex = "M", Description = "This kitten hides in plastic bags" },
          new Animal { AnimalId = 3, Species = "Dog", Name = "Nathan", Age = 4, Sex = "M", Description = "He only eats hotdogs with ketchup" },
          new Animal { AnimalId = 4, Species = "Dog", Name = "Brenda", Age = 12, Sex = "F", Description = "She's on her way out, tbh" },
          new Animal { AnimalId = 5, Species = "Cat", Name = "Toothpick", Age = 1, Sex = "F", Description = "She stares at herself in the reflection" },
          new Animal { AnimalId = 6, Species = "Dog", Name = "Sea Shell Girl", Age = 1, Sex = "F", Description = "She can barely eat a kibble she's so smol" },
          new Animal { AnimalId = 7, Species = "Dog", Name = "Butter", Age = 3, Sex = "M", Description = "Will take bites out of butter if left on the counter" },
          new Animal { AnimalId = 8, Species = "Cat", Name = "Oyster", Age = 2, Sex = "F", Description = "Loves to nap in dog beds" },
          new Animal { AnimalId = 9, Species = "Dog", Name = "Chad", Age = 2, Sex = "M", Description = "Just your basic golden retriever" }
        );
    }

  }
}