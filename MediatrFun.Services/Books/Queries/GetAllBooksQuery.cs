using System.Collections.Generic;
using MediatR;
using Mediatr.Services.Models;

namespace MediatrFun.Services.Books.Queries
{
    public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
    {

    }

    
}