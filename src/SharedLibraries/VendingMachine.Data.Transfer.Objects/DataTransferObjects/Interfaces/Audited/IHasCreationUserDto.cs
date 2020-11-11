using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface IHasCreationUserDto
    {
        Guid? CreatorUserId { get; set; }
    }
}
