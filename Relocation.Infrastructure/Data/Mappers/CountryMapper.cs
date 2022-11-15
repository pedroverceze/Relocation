using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relocation.Domain.Country.Entity;

namespace Relocation.Infrastructure.Data.Mappers
{
    public class CountryMapper : IEntityTypeConfiguration<CountryEntity>
    {
        public void Configure(EntityTypeBuilder<CountryEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
