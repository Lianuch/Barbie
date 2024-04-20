using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class RecordConfigurations : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder
            .HasKey(r => r.Id);

        builder
            .HasOne(h => h.HaircutType)
            .WithMany(r => r.Records)
            .HasForeignKey(h => h.HaircutTypeId)
            .OnDelete(DeleteBehavior.ClientNoAction);

        builder
            .HasOne(a => a.Admin)
            .WithMany(r => r.Records)
            .HasForeignKey(a => a.AdminId)
            .OnDelete(DeleteBehavior.ClientNoAction);

        builder
            .HasOne(c => c.Client)
            .WithMany(r => r.Records)
            .HasForeignKey(c => c.ClientId)
            .OnDelete(DeleteBehavior.ClientNoAction);

        builder
            .HasOne(b => b.Barber)
            .WithMany(r => r.Records)
            .HasForeignKey(b => b.BarberId)
            .OnDelete(DeleteBehavior.ClientNoAction);
    }
}

     