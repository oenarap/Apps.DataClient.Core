using System.Threading.Tasks;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Updates an existing item with a resource key and a specified result type.
    /// </summary>
    public interface IUpdateAsync<TKey, TItem, TResult>
    {
        Task<TResult> UpdateAsync(TKey key, TItem item);
    }

    /// <summary>
    /// Updates an existing item with a specified result type.
    /// </summary>
    public interface IUpdateAsync<TItem, TResult>
    {
        Task<TResult> UpdateAsync(TItem item);
    }

    /// <summary>
    /// Updates an existing item of <see cref="T"/> type.
    /// </summary>
    public interface IUpdateAsync<T>
    {
        Task<bool> UpdateAsync(T item);
    }
}
