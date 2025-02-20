using BookManagement.DataAccess.Data;
using BookManagement.DataAccess.Operations.Services;
using BookManagement.Models.Entities;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.AddBooks
{
    public class AddBooksCommandHandler: IRequestHandler<AddBooksCommand>
    {
        private readonly ApplicationDbContext _context;

        public AddBooksCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(AddBooksCommand request, CancellationToken cancellationToken)
        {
            foreach (var bookDTO in request.Books)
            {
                if (await BookService.IsTitleAlreadyInTheBaseAsync(bookDTO.Title, _context))
                {
                    throw new Exception($"Book with the title {bookDTO.Title} already exists");
                }

                var book = new Book
                {
                    Title = bookDTO.Title,
                    AuthorName = bookDTO.AuthorName,
                    PublicationYear = bookDTO.PublicationYear,
                    ViewsCount = 0,
                    IsDeleted = false,
                };
                await _context.AddAsync(book);
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}