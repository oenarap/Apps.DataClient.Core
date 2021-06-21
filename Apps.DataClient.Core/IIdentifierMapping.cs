using System;

namespace Apps.DataClient.Core
{
    public interface IIdentifierMapping
    {
        Guid Get(Guid id);
        Guid Create(Guid id);
    }
}