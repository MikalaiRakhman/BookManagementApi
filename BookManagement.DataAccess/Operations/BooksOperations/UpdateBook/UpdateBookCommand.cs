using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BookManagement.DataAccess.Operations.BooksOperations.UpdateBook
{
    public class UpdateBookCommand: IRequest
    {
        [Required(ErrorMessage = "Title cannot be null or empty")]
        [MaxLength(100, ErrorMessage = "Title cannot be more than 100 characters")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Title can only contain letters, numbers and spaces")]
        public string Title { get; set; }
        [Required(ErrorMessage = "New title cannot be null or empty")]
        [MaxLength(100, ErrorMessage = "New title cannot be more than 100 characters")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "New title can only contain letters, numbers and spaces")]
        public string NewTitle { get; set; }
        [Required(ErrorMessage = "Author name cannot be null or empty")]
        [MaxLength(100, ErrorMessage = "Author name cannot be more than 100 characters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Author name can only contain letters and spaces")]
        public string AuthorName { get; set; }
        [Range(1000, 2025, ErrorMessage = "Publication year must be between 1000 and the current year")]
        public int PublicationYear { get; set; }
    }
}
