using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrFun.Data.Models;

namespace MediatrFun.Services.Books.Queries
{
    public class GetAllBooksQuery : IRequest<Response<List<Book>>>
    {

    }

    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, Response<List<Book>>>
    {
        public async Task<Response<List<Book>>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books =  await Task.FromResult(new List<Book>
            {
                new Book {Name = "Book A"},
                new Book {Name = "Book B"}
            });
            return Response.Ok(books, "Result returned successfully.");
        }
    }


}