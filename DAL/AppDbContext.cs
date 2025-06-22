using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.DAL;

public class AppDbContext : DbContext
{
    DbSet<Employee> Employees { get; set; }
    public DbSet<Nursery> Nurseries { get; set; }
    DbSet<Responsible> Responsibles { get; set; }
    public DbSet<Seedling_Batch> SeedlingBatches { get; set; }
    DbSet<Tree_Species> TreeSpecies { get; set; }
    protected AppDbContext()
    {
    }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                EmployeeId = 1,
                FirstName = "Jan",
                LastName = "Nowak",
                HireDate = new DateOnly(2020, 1, 1)
            },
            new Employee
            {
                EmployeeId = 2,
                FirstName = "Anna",
                LastName = "Kowalska",
                HireDate = new DateOnly(2020, 1, 1)
            }
        );
        modelBuilder.Entity<Nursery>().HasData(
            new Nursery
            {
                NurseryId = 1,
                Name = "szkola lesna 1",
                EstablishedDate = new DateOnly(1990, 5, 15),
            },
            new Nursery
            {
                NurseryId = 2,
                Name = "szkola lesna 2",
                EstablishedDate = new DateOnly(1995, 3, 10),
            }
        );
        modelBuilder.Entity<Tree_Species>().HasData(
            new Tree_Species
            {
                SpeciesId = 1,
                LatinName = "Quercus robur",
                GrowthTimeInYears = 30,
            },
            new Tree_Species
            {
                SpeciesId = 2,
                LatinName = "Pinus sylvestris",
                GrowthTimeInYears = 20,
            }
        );
        modelBuilder.Entity<Responsible>().HasKey(l => new { l.EmployeeId, l.BatchId });
        modelBuilder.Entity<Seedling_Batch>().HasData(
        new Seedling_Batch 
        {
            BatchId = 1,
            NurseryId = 1,
            SpeciesId = 1,
            Quantity = 1000,
            SownDate = new DateOnly(2023, 4, 1),
            ReadyDate = null,
        }

        );
    }
}