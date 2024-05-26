using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class BarberConfigurations : IEntityTypeConfiguration<Barber>
{
    public void Configure(EntityTypeBuilder<Barber> builder)
    {
        builder
            .HasKey(b => b.Id);

        builder
            .HasOne(u => u.User)
            .WithOne(b => b.Barber)
            .HasForeignKey<Barber>(u => u.UserId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}