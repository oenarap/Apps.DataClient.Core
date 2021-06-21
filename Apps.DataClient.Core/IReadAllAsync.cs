using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Apps.DataClient.Core
{
    public interface IReadAllAsync<TKey, TResult>
    {
        Task<IEnumerable<TResult>> ReadAllAsync(TKey key);
    }

    /// <summary>
    /// Returns all existing entities.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public interface IReadAllAsync<T>
    {
        Task<IEnumerable<T>> ReadAllAsync();
        // TODO: use this on .NetStandard 2.1 or higher
        // ValueTask<IEnumerable<T>> ReadAllAsync();
    }
}
