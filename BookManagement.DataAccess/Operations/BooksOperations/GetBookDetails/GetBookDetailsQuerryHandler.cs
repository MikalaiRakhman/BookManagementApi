using BookManagement.DataAccess.Data;
using BookManagement.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.BooksOperations.GetBookDetails
{
    public class GetBookDetailsQuerryHandler: IRequestHandler<GetBookDetailsQuerry, Book>
    {
        private readonly ApplicationDbContext _context;

        public GetBookDetailsQuerryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> Handle(GetBookDetailsQuerry request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FirstAsync(x => x.Title == request.Title);
            Guard.AgainstNull(book, nameof(book));

            book.ViewsCount++;

            await _context.SaveChangesAsync(cancellationToken);

            return book;
        }
    }
}
