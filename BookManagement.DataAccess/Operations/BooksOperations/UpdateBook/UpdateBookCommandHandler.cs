using BookManagement.DataAccess.Data;
using MediatR;

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
            var book = await _context.Books.FindAsync(request.BookId);
            Guard.AgainstNull(book, nameof(book));

            book.Title = request.Title;
            book.AuthorName = request.AuthorName;
            book.PublicationYear = request.PublicationYear;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
