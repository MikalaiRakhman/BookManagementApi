using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.CreateBook
{
    public record CreateBookCommand: IRequest
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
    }
}
