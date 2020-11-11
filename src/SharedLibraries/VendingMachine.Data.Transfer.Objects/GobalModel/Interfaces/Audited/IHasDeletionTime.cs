using System;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface IHasDeletionTime
    {
        DateTime? DeletionTime { get; set; }
    }
}
