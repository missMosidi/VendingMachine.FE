using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface IHasModificationUserDto
    {
        Guid? LastModifierUserId { get; set; }
    }
}
