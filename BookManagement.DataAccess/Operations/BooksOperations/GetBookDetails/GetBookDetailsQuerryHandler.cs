using BookManagement.DataAccess.Data;
using BookManagement.DataAccess.Operations.Models.DTOModels;
using BookManagement.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.BooksOperations.GetBookDetails
{
    public class GetBookDetailsQuerryHandler: IRequestHandler<GetBookDetailsQuerry, BookDetailsDTOModel>
    {
        private readonly ApplicationDbContext _context;

        public GetBookDetailsQuerryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookDetailsDTOModel> Handle(GetBookDetailsQuerry request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FirstAsync(x => x.Title == request.Title);
            Guard.AgainstNull(book, nameof(book));

            book.ViewsCount++;

            var bookDetails = new BookDetailsDTOModel
            {
                Title = book.Title,
                AuthorName = book.AuthorName,
                PublicationYear = book.PublicationYear,
                ViewsCount = book.ViewsCount,
                IsDeleted = book.IsDeleted,
                PopularityScore = (int)(book.ViewsCount * 0.5 + (DateTime.Now.Year - book.PublicationYear) * 2)
            };

            await _context.SaveChangesAsync(cancellationToken);

            return bookDetails;
        }
    }
}
