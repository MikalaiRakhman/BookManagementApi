using BookManagement.Models.Entities;
using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.GetBookDetails
{
    public record GetBookDetailsQuerry: IRequest<Book>
    {
        public string Title { get; set; }
    }
}
