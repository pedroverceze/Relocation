using Microsoft.EntityFrameworkCore;
using Relocation.Infrastructure.Data.Mappers;

namespace Relocation.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClientMapper());
            builder.ApplyConfiguration(new PropertyMapper());
        }
    }
}