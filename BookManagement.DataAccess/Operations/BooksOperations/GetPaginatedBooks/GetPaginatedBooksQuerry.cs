using BookManagement.DataAccess.Operations.Models;
using BookManagement.DataAccess.Operations.Models.DTOModels;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.GetPaginatedBooks
{
    public record GetPaginatedBooksQuerry: IRequest<PaginatedListModel<BookTitleDTOModel>>
    {
        public int PageSize { get; init; } = 10;
        public int CurrentPage { get; init; } = 1;
    }
}