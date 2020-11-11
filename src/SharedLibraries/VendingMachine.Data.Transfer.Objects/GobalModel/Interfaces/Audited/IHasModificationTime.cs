using System;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface IHasModificationTime
    {
        DateTime? ModicationTime { get; set; }
    }
}
