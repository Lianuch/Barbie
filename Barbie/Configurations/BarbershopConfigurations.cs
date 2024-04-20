using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class BarbershopConfigurations : IEntityTypeConfiguration<Barbershop>
{
    public void Configure(EntityTypeBuilder<Barbershop> builder)
    {
        builder
            .HasKey(k => k.Id);
        builder
            .HasOne(l => l.Location)
            .WithOne(b => b.Barbershop)
            .HasForeignKey<Location>(l => l.BarbershopId);

        builder

            .HasMany(b => b.BarberBarbershops)
            .WithOne(b => b.Barbershop);

        builder
            .HasMany(b => b.BarbershopClients)

            .WithOne(b => b.Barbershop);
    }
}