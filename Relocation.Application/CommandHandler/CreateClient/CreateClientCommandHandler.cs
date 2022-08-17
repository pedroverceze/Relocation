using MediatR;
using Relocation.Application.CommandHandler.CreateClient.Input;

namespace Relocation.Application.CommandHandler.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommandRequest>
    {
        public Task<Unit> Handle(CreateClientCommandRequest request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            throw new NotImplementedException();
        }
    }
}