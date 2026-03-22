using Microsoft.EntityFrameworkCore;
using prac1.Models;

namespace prac1.Data;

public class AppDbContext : DbContext
{
    public DbSet<RentalPoint> RentalPoints => Set<RentalPoint>();
    public DbSet<Scooter> Scooters => Set<Scooter>();
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ScooterRentalDb;User Id=sa;Password=Prokhorsdz1234;TrustServerCertificate=True");
    }
}