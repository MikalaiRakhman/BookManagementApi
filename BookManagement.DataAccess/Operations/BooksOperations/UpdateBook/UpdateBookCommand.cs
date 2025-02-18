using MediatR;

namespace BookManagement.DataAccess.Operations.BooksOperations.UpdateBook
{
    public class UpdateBookCommand: IRequest
    {
        public string Title { get; set; }
        public string NewTitle { get; set; }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
    }
}
