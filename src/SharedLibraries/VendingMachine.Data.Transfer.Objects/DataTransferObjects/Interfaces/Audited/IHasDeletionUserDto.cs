using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface IHasDeletionUserDto
    {
        Guid? DeleterUserId { get; set; }
    }
}
