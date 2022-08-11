using Relocation.Domain.Client.Entity;
using Relocation.Domain.Country.Entity;
using Relocation.Domain.Shared;

namespace Relocation.Domain.Property.Entity
{
    public class PropertyEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public CountryEntity Country { get; set; }
        public string PostalCode {get; set;}
        public string Link { get; set; }      
        public decimal Value { get; set; }  
        public bool HasGuarantee { get; set; } 
        public decimal GuaranteeValue { get; set; }
        public bool Active { get; set; }
        public bool Balcony { get; set; }
        public int Area { get; set; }
        public DateTime AvailabilityDate { get; set; }
        public string Commentary { get; set; }
        public ICollection<ClientEntity> Clients { get; set; }
    }
}