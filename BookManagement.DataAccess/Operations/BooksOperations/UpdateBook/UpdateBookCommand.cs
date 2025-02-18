using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.UpdateBook
{
    public class UpdateBookCommand: IRequest
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
    }
}
