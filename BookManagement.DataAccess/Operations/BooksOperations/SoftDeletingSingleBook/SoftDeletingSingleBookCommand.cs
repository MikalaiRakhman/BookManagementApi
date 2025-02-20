using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingSingleBook
{
    public record SoftDeletingSingleBookCommand : IRequest
    {
        public string Title { get; init; }
    }
}