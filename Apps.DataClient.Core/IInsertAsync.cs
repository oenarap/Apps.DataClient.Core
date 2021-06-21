using System.Threading.Tasks;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Inserts a new item with a resource key and a specified result type.
    /// </summary>
    public interface IInsertAsync<TItem, TResult, TKey>
    {
        Task<TResult> InsertAsync(TItem item, TKey key);
    }

    /// <summary>
    /// Inserts a new entity with a specified result.
    /// </summary>
    public interface IInsertAsync<TItem, TResult>
    {
        Task<TResult> InsertAsync(TItem item);
    }

    /// <summary>
    /// Inserts a new item and returns result of the same type.
    /// </summary>
    public interface IInsertAsync<T>
    {
        Task<bool> InsertAsync(T item);
    }
}
