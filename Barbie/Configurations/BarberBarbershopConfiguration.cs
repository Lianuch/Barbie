using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class BarberBarbershopConfiguration : IEntityTypeConfiguration<BarberBarbershop>
{
    public void Configure(EntityTypeBuilder<BarberBarbershop> builder)
    {
        builder
            .HasKey(k => new { k.BarberId, k.BarbershopId });
        builder
            .HasOne(b => b.Barber)
            .WithMany(b => b.BarberBarbershops)
            .HasForeignKey(b => b.BarberId);  
           
        builder 
            .HasOne(b => b.Barbershop)
            .WithMany(b => b.BarberBarbershops)
            .HasForeignKey(b => b.BarbershopId);
    }
}