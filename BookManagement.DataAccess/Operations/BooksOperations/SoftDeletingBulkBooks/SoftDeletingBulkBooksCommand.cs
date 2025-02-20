using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingBulkBooks
{
    public record SoftDeletingBulkBooksCommand: IRequest
    {
        public List<string> Titles { get; init; }
    }
}