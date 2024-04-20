using Barbie.Configurations;
using Barbie.Models;
using Microsoft.EntityFrameworkCore;

namespace Barbie.Data;

public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<HaircutType> HaircutTypes { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Barber> Barbers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Barbershop> Barbershops { get; set; }
    public DbSet<BarberBarbershop> BarberBarbershops { get; set; }
    public DbSet<BarbershopClient> BarbershopClients { get; set; }

    public DbSet<Record> Records { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new BarberConfigurations());
        modelBuilder.ApplyConfiguration(new UserConfigurations());
        modelBuilder.ApplyConfiguration(new AdminConfigurations());
        modelBuilder.ApplyConfiguration(new ClientConfigurations());

        modelBuilder.ApplyConfiguration(new BarbershopConfigurations());
        modelBuilder.ApplyConfiguration(new BarberBarbershopConfiguration());
        modelBuilder.ApplyConfiguration(new BarbershopClientConfigurations());

        modelBuilder.ApplyConfiguration(new RecordConfigurations());
        modelBuilder.ApplyConfiguration(new ReviewConfigurations());
        modelBuilder.ApplyConfiguration(new LocationConfigurations());
        modelBuilder.ApplyConfiguration(new HaircutTypeConfigurations());



    }
}