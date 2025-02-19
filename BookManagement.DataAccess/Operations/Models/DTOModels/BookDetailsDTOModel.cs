

namespace BookManagement.DataAccess.Operations.Models.DTOModels
{
    public class BookDetailsDTOModel
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
        public int ViewsCount { get; set; }
        public bool IsDeleted { get; set; }
        public int PopularityScore { get; set; }
    }
}
