namespace MediatrFun.Services.Books.Handlers
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<Book>
            {
                new Book {Title = "Book A"},
                new Book {Title = "Book B"}
            });
        }
    }
}