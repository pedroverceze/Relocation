using MediatR;

namespace Relocation.Application.CommandHandler.CreateProperty
{
    public class CreatePropertyCommandRequest : IRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
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
    }
}