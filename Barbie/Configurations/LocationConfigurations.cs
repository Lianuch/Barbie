using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class LocationConfigurations : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder
            .HasKey(e => e.Id);

        builder
            .HasOne(b => b.Barbershop)
            .WithOne(l => l.Location)
            .HasForeignKey<Location>(b => b.BarbershopId);




    }
}