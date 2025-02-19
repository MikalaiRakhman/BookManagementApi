using BookManagement.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.Services
{
    public static class BookService
    {
        public static async Task<bool> IsTitleAlreadyInTheBaseAsync(string title, ApplicationDbContext context)
        {
            return await context.Books.AnyAsync(b => b.Title.ToLower() == title.ToLower());
        }
    }
}
