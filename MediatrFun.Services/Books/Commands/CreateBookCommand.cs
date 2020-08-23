using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrFun.Services.Books.Commands
{
    public class CreateBookCommand : IRequest<string>
    {
        
    }

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, string>
    {
        public Task<string> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}