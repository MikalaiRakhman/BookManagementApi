using FluentValidation;

namespace BookManagement.DataAccess.Operations.BooksOperations.CreateBook
{
    public class CreateBookCommandValidator: AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(b => b.Title)
                .NotNull()
                .NotEmpty()
                .WithMessage("Title cannot be null or empty")
                .MaximumLength(100)
                .WithMessage("Title cannot be more than 100 characters")
                .Matches("^[a-zA-Z0-9 ]*$")
                .WithMessage("Title can only contain letters, numbers and spaces");

            RuleFor(b => b.AuthorName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Author name cannot be null or empty")
                .MaximumLength(100)
                .WithMessage("Author name cannot be more than 100 characters")
                .Matches("^[a-zA-Z ]*$")
                .WithMessage("Author name can only contain letters and spaces");

            RuleFor(b => b.PublicationYear)
                .NotEmpty()
                .NotNull()
                .WithMessage("Publication year cannot be null or empty")
                .InclusiveBetween(1000, DateTime.Now.Year)
                .WithMessage($"Publication year must be between 1000 and {DateTime.Now.Year}");
        }
    }
}
