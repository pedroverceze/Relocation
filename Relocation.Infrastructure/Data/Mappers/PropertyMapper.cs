using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relocation.Domain.Client.Entity;
using Relocation.Domain.Property.Entity;

namespace Relocation.Infrastructure.Data.Mappers
{
    public class PropertyMapper : IEntityTypeConfiguration<PropertyEntity>
    {
        public void Configure(EntityTypeBuilder<PropertyEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasMany<ClientEntity>(c => c.Clients)
                   .WithMany(p => p.Properties);
        }
    }
}