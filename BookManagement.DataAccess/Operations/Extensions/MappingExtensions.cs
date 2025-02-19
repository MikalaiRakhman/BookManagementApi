using BookManagement.DataAccess.Operations.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Operations.Extensions
{
    public static class MappingExtensions
    {
        public static Task<PaginatedListModel<TDestination>> ToPaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageSize, int currentPage)
            where TDestination : class
        {
            return PaginatedListModel<TDestination>.CreateAsync(queryable.AsNoTracking(), pageSize, currentPage);
        }
    }
}
