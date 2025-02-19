using BookManagement.DataAccess.Operations.Models.DTOModels;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.AddBooks
{
    public record AddBooksCommand: IRequest
    {
        public List<BookDTOModel> Books { get; set; }
    }
}
