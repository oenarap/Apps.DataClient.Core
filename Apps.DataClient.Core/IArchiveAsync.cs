using System.Threading.Tasks;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Archives an existing item with a resource key and a specified result type.
    /// </summary>
    public interface IArchiveAsync<TItem, TResult, TKey>
    {
        Task<TResult> ArchiveAsync(TItem item, TKey key);
    }

    /// <summary>
    /// Archives an existing item with specified result type.
    /// </summary>
    public interface IArchiveAsync<TItem, TResult>
    {
        Task<TResult> ArchiveAsync(TItem item);
    }

    /// <summary>
    /// Archives an existing item.
    /// </summary>
    public interface IArchiveAsync<T>
    {
        Task<bool> ArchiveAsync(T item);
    }
}