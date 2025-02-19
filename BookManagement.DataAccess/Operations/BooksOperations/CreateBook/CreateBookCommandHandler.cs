using BookManagement.DataAccess.Data;
using BookManagement.DataAccess.Operations.Services;
using BookManagement.Models.Entities;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly ApplicationDbContext _context;

        public CreateBookCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            if(await BookService.IsTitleAlreadyInTheBaseAsync(request.Title, _context))
            {
                throw new Exception("Book with this title already exists");
            }

            var book = new Book
            {
                Title = request.Title,
                AuthorName = request.AuthorName,
                PublicationYear = request.PublicationYear,
                ViewsCount = 0,
                IsDeleted = false,
            };

            await _context.AddAsync(book);

            await _context.SaveChangesAsync(cancellationToken);
        }        
    }
}
