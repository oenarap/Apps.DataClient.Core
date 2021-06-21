using System.Threading.Tasks;
using System.Collections.Generic;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Inserts a range of new items with a resource key and a specified result type.
    /// </summary>
    public interface IInsertRangeAsync<TItem, TResult, TKey>
    {
        Task<TResult> InsertRangeAsync(IEnumerable<TItem> items, TKey key);
    }

    /// <summary>
    /// Inserts a range of new items with a specified result type.
    /// </summary>
    public interface IInsertRangeAsync<TItem, TResult>
    {
        Task<TResult> InsertRangeAsync(IEnumerable<TItem> items);
    }

    /// <summary>
    /// Inserts a range of new items.
    /// </summary>
    public interface IInsertRangeAsync<T>
    {
        Task<int> InsertRangeAsync(IEnumerable<T> items);
    }
}
