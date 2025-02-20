using BookManagement.DataAccess.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.BooksOperations.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly ApplicationDbContext _context;

        public UpdateBookCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FirstAsync(b => b.Title == request.Title, cancellationToken);
            Guard.AgainstNull(book, nameof(book));

            book.Title = request.NewTitle;
            book.AuthorName = request.AuthorName;
            book.PublicationYear = request.PublicationYear;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}