using BookManagement.DataAccess.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingBulkBooks.SoftDeletingSingleBook
{
    public class SoftDeletingSingleBookCommandHandler : IRequestHandler<SoftDeletingSingleBookCommand>
    {
        private readonly ApplicationDbContext _context;

        public SoftDeletingSingleBookCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(SoftDeletingSingleBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Title == request.Title);
            Guard.AgainstNull(book, nameof(book));

            book.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
