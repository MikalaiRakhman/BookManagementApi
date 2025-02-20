using System.ComponentModel.DataAnnotations;

namespace BookManagement.Models.Entities
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
        public int ViewsCount { get; set; } = 0;
        public bool IsDeleted { get; set; } = false;
    }
}
