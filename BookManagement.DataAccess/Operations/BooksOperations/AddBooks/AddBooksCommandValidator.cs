using BookManagement.Models.Entities;
using FluentValidation;

namespace BookManagement.DataAccess.Operations.BooksOperations.AddBooks
{
    public class AddBooksCommandValidator: AbstractValidator<AddBooksCommand>
    {
        public AddBooksCommandValidator()
        {
            RuleFor(b => b.Books)
                .NotNull()
                .NotEmpty()
                .WithMessage("Books cannot be null or empty");
                .SetValidator(new BookValidator());


        }
    }
}
