using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.Models
{
    public class PaginatedListModel<T>
    {
        public IReadOnlyCollection<T> Items { get; }
        public int CurrentPage { get; }
        public int TotalCount { get; }
        public int TotalPages { get; }
        public int PageSize { get; }

        public PaginatedListModel(IReadOnlyCollection<T> items, int totalCount, int pageSize, int currentPage)
        {
            Items = items;
            TotalCount = totalCount;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            PageSize = pageSize;
            CurrentPage = currentPage;
        }

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
        public static async Task<PaginatedListModel<T>> CreateAsync(IQueryable<T> source, int pageSize, int currentPage)
        {
            var totalCount = await source.CountAsync();
            var items = await source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedListModel<T>(items, totalCount, pageSize, currentPage);
        }
    }
}