using BookManagement.DataAccess.Operations.Models.DTOModels;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.GetBookDetails
{
    public record GetBookDetailsQuerry: IRequest<BookDetailsDTOModel>
    {
        public string Title { get; set; }
    }
}
