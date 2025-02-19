using BookManagement.DataAccess.Data;
using BookManagement.DataAccess.Operations.Extensions;
using BookManagement.DataAccess.Operations.Models;
using BookManagement.DataAccess.Operations.Models.DTOModels;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.GetPaginatedBooks
{
    public class GetPaginatedBooksQuerryHandler : IRequestHandler<GetPaginatedBooksQuerry, PaginatedListModel<BookTitleDTOModel>>
    {
        private readonly ApplicationDbContext _context;

        public GetPaginatedBooksQuerryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedListModel<BookTitleDTOModel>> Handle(GetPaginatedBooksQuerry request, CancellationToken cancellationToken)
        {
            return await _context.Books
                .Where(b => b.IsDeleted == false)
                .Select(b => new BookTitleDTOModel
                {
                    Title = b.Title
                })
                .ToPaginatedListAsync(request.PageSize, request.CurrentPage);
        }
    }
}