using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class BarbershopClientConfigurations : IEntityTypeConfiguration<BarbershopClient>
{
    public void Configure(EntityTypeBuilder<BarbershopClient> builder)
    {
        builder
            .HasKey(k => new { k.ClientId, k.BarbershopId });

        builder
            .HasOne(c => c.Client)
            .WithMany(b => b.BarbershopClients)
            .HasForeignKey(c => c.ClientId);
        
         builder
            .HasOne(c => c.Barbershop)
            .WithMany(b => b.BarbershopClients)
            .HasForeignKey(c => c.BarbershopId);
        
        
    }
}