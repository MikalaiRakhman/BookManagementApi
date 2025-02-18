using BookManagement.DataAccess.Operations.DTOModels;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.AddBooks
{
    public record AddBooksCommand: IRequest
    {
        public List<BookDTO> Books { get; set; }
    }
}
