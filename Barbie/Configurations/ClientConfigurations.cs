using Barbie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbie.Configurations
{
    public class ClientConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .HasOne(u=>u.User)
                .WithOne(c=>c.Client)
                .HasForeignKey<Client>(c => c.UserId);

            builder
                .HasMany(r => r.Records)
                .WithOne(c => c.Client);

            builder
                .HasMany(r => r.Reviews)
                .WithOne(c=>c.Client);
        }
    }
}
