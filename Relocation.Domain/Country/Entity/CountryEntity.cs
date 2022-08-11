using Relocation.Domain.Shared;
using Relocation.Domain.Shared.Enum;

namespace Relocation.Domain.Country.Entity
{
    public class CountryEntity : BaseEntity
    {
        public string Name { get; set; }
        public CurrencyCode Currency { get; set; }
        public int CountryTelCode { get; set; }
    }
}