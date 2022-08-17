using MediatR;

namespace Relocation.Application.CommandHandler.CreateClient.Input
{
    public class CreateClientCommandRequest : IRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int FamilyMembers { get; set; }
        public bool Pet { get; set; }
        public string Visa { get; set; }
        public string Country { get; set; }
    }
}