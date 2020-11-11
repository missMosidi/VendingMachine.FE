using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface IHasDeletionTimeDto
    {
        DateTime? DeletionTime { get; set; }
    }
}
