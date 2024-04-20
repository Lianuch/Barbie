using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations
{
    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .HasOne(u => u.User)
                .WithOne(a => a.Admin)
                .HasForeignKey<Admin>(u => u.UserId);
            builder
                .HasMany(a => a.Records)
                .WithOne(r => r.Admin);

            builder
                .HasMany(r => r.Reviews)
                .WithOne(a => a.Admin);

        }
    }
}
