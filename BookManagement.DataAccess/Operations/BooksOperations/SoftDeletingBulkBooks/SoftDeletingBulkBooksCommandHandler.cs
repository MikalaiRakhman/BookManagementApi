using BookManagement.DataAccess.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingBulkBooks
{
    public class SoftDeletingBulkBooksCommandHandler : IRequestHandler<SoftDeletingBulkBooksCommand>
    {
        private readonly ApplicationDbContext _context;

        public SoftDeletingBulkBooksCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Handle(SoftDeletingBulkBooksCommand request, CancellationToken cancellationToken)
        {
            foreach (var title in request.Titles)
            {
                var book = await _context.Books.FirstAsync(b => b.Title == title);
                Guard.AgainstNull(book, nameof(book));

                book.IsDeleted = true;
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
