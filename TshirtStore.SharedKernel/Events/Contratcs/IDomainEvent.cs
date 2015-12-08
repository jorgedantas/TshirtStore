using System;

namespace TshirtStore.SharedKernel.Events.Contratcs
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
