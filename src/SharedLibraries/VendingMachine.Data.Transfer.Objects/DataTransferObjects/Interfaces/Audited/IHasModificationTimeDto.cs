using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface IHasModificationTimeDto
    {
        DateTime? ModicationTime { get; set; }
    }
}
