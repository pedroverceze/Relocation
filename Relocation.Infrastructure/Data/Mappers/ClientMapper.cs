using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relocation.Domain.Client.Entity;
using Relocation.Domain.Property.Entity;

namespace Relocation.Infrastructure.Data.Mappers
{
    public class ClientMapper : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasMany<PropertyEntity>(p => p.Properties)
                    .WithMany(p => p.Clients);
        }
    }
}