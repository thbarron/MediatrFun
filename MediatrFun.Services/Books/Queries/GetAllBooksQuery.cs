using System.Collections.Generic;
using MediatR;
using MediatrFun.Data.Models;

namespace MediatrFun.Services.Books.Queries
{
    public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
    {

    }

    
}