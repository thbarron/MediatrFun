using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrFun.Data.Models;
using MediatrFun.Data.Repositories.Implementations;
using MediatrFun.Data.Repositories.Interfaces;

namespace MediatrFun.Services.Books.Commands
{
    public class CreateBookCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
    }

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Response<int>>
    {
        private readonly IBookRepository _repository;

        public CreateBookCommandHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response<int>> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Name = request.Name
            };
            var result  = await _repository.Add(book);
            return Response.Ok(result, "Book successfully added.");
        }
    }
}