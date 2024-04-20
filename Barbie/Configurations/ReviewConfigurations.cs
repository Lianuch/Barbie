using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations;

public class ReviewConfigurations : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder
            .HasKey(r => r.Id);

        builder
            .HasOne(c => c.Client)
            .WithMany(r=>r.Reviews)
            .HasForeignKey(c => c.ClientId)
            .OnDelete(DeleteBehavior.ClientNoAction);


        builder
            .HasOne(b => b.Barber)
            .WithMany(r => r.Reviews)
            .HasForeignKey(b => b.BarberId)
            .OnDelete(DeleteBehavior.ClientNoAction);


        builder
            .HasOne(b=>b.Barber)
            .WithMany(r=>r.Reviews)
            .HasForeignKey(b => b.BarberId);
      
    }
}