using System.Threading.Tasks;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Deletes an existing item with a resource key and a specified result type.
    /// </summary>
    public interface IDeleteAsync<TItem, TResult, TKey>
    {
        Task<TResult> DeleteAsync(TItem item, TKey key);
    }

    /// <summary>
    /// Deletes an existing item with specified result type.
    /// </summary>
    public interface IDeleteAsync<TItem, TResult>
    {
        Task<TResult> DeleteAsync(TItem item);
    }

    /// <summary>
    /// Deletes a specified entity.
    /// </summary>
    public interface IDeleteAsync<T>
    {
        Task<bool>DeleteAsync(T item);
    }
}
