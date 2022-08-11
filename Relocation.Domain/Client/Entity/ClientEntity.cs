using System.Collections.ObjectModel;
using Relocation.Domain.Country.Entity;
using Relocation.Domain.Property.Entity;
using Relocation.Domain.Shared;

namespace Relocation.Domain.Client.Entity
{
    public class ClientEntity : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int FamilyMembers { get; set; }
        public bool Pet { get; set; }
        public string Visa { get; set; }
        public CountryEntity Country { get; set; }
        public ICollection<PropertyEntity> Properties { get; set; }
    }
}