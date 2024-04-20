using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(u => u.Id);

        builder
            .HasOne(a => a.Admin)
            .WithOne(u => u.User)
            .HasForeignKey<Admin>(a => a.UserId);

        builder
            .HasOne(c => c.Client)
            .WithOne(u => u.User)
            .HasForeignKey<Client>(c => c.UserId);

        builder
            .HasOne(b => b.Barber)
            .WithOne(u => u.User)
            .HasForeignKey<Barber>(b => b.UserId);


        builder
            .HasOne(b=>b.Barbershop)
            .WithMany(u=>u.Users)
            .HasForeignKey(b=>b.BarbershopId);
     
    }
}