using Medical.Domain.Entity;
using Medical.Domain.Hospitals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.EntityTypeConfiguration
{
    public class HospitalsConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            _ = builder.HasKey(h => h.Id);
            _ = builder.Property(h => h.Name);
            _ = builder.Property(h => h.City);

        }
    }
}
