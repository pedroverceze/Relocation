using Microsoft.EntityFrameworkCore;
using Relocation.Domain.Client.Entity;
using Relocation.Domain.Property.Entity;
using Relocation.Infrastructure.Data.Mappers;

namespace Relocation.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {        
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.ApplyConfiguration(new ClientMapper());
        }
    }
}