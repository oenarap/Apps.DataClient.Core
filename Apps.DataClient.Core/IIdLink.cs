using System;

namespace Apps.DataClient.Core
{
    /// <summary>
    /// Links two identifiers.
    /// </summary>
    public interface IIdLink
    {
        Guid Id { get; }
        Guid? LinkedId { get; }
    }
}