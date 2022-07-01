using Medical.Domain.Entity;
using Medical.Domain.Hospitals;
using Medical.Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.EntityTypeConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            _ = builder.HasKey(u => u.Id);
            _ = builder.Property(u => u.Login);
            _ = builder.Property(u => u.Password);            
        }
    }
}
