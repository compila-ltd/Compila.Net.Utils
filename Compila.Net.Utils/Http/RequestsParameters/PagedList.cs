using System.ComponentModel;

namespace Compila.Net.Utils.Http.RequestsParameters
{
    public class PagedList<T> : List<T>
    {
        public RequestMetadata Metadata { get; set; }

        public PagedList(List<T> items, int count, int pageSize, int pageNumber)
        {
            Metadata = new RequestMetadata
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };

            AddRange(items);
        }

        /// <summary>
        /// Deprecated: synchronous enumeration-based paging will be removed in a future release.
        /// Use <see cref="ToPagedListAsync(IQueryable{T}, int, int, Func{IQueryable{T}, Task{int}}, Func{IQueryable{T}, Task{List{T}}})"/>
        /// or perform paging on the caller using async query methods (for example EF Core's async methods).
        /// </summary>
        [Obsolete("ToPagedList(IEnumerable<T>...) is deprecated and will be removed in a future release. " +
                  "Use ToPagedListAsync(IQueryable<T>, ...) or perform paging with async queries instead.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedList<T>(items, count, pageSize, pageNumber);
        }

        public static async Task<PagedList<T>> ToPagedListAsync(IQueryable<T> source, int pageNumber, int pageSize, Func<IQueryable<T>,
            Task<int>> countFunc, Func<IQueryable<T>, Task<List<T>>> listFunc)
        {
            var count = await countFunc(source);

            var items = await listFunc(source.Skip((pageNumber - 1) * pageSize).Take(pageSize));

            return new PagedList<T>(items, count, pageSize, pageNumber);
        }
    }
}
