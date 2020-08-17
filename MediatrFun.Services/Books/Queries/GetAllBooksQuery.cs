using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Mediatr.Services.Models;

namespace Mediatr.Services.Queries
{
    public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
    {

    }

    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<Book>
            {
                new Book{Title = "Book A"},
                new Book{Title = "Book B"}
            });
        }
    }
}