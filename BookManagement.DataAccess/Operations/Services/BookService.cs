using BookManagement.DataAccess.Data;
using BookManagement.DataAccess.Operations.Models.DTOModels;
using BookManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookManagement.DataAccess.Operations.Services
{
    public static class BookService
    {
        public static async Task<bool> IsTitleAlreadyInTheBaseAsync(string title, ApplicationDbContext context)
        {
            return await context.Books.AnyAsync(b => b.Title.ToLower() == title.ToLower());
        }

        public static bool ValidateBookDTOModel(List<BookDTOModel> books, out List<ValidationResult> validationResults)
        {
            var isValid = true;
            validationResults = new List<ValidationResult>();

            var context = new ValidationContext(books);

            foreach (var book in books)
            {
                var results = new List<ValidationResult>();
                var bookContext = new ValidationContext(book);

                if (!Validator.TryValidateObject(book, bookContext, results, true))
                {
                    isValid = false;
                    validationResults.AddRange(results);
                }
            }

            return isValid;
        }
    }
}
