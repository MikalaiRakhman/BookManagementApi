using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingBulkBooks.SoftDeletingSingleBook
{
    public record SoftDeletingSingleBookCommand : IRequest
    {
        public string Title { get; init; }
    }
}
