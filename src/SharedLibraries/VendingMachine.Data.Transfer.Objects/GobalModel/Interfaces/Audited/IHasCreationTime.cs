using System;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}
