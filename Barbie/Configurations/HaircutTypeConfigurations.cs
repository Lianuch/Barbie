using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class HaircutTypeConfigurations : IEntityTypeConfiguration<HaircutType>
{
    public void Configure(EntityTypeBuilder<HaircutType> builder)
    {
        builder
            .HasKey(h => h.Id);
        builder
            .HasMany(r => r.Records)
            .WithOne(h => h.HaircutType);



    }
}