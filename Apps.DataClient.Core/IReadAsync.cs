using System;
using System.Threading.Tasks;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Retrieves an existing item using a specific key.
    /// </summary>
    public interface IReadAsync<TKey, TResult>
    {
        Task<TResult> ReadAsync(TKey key);
        // TODO: use ValueTask<T> on .NetStandard 2.1 or higher
        // ValueTask<TResult> ReadAsync(Tparam param);
    }

    /// <summary>
    /// Retrieves an existing item using a unique identifier.
    /// </summary>
    public interface IReadAsync<T>
    {
        Task<T> ReadAsync(Guid id);
        // TODO: use ValueTask<T> on .NetStandard 2.1 or higher
        // ValueTask<T> ReadAsync(Guid id);
    }
}
