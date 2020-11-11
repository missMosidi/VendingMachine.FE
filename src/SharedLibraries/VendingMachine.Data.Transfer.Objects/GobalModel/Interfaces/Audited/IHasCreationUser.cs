using System;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface IHasCreationUser
    {
        Guid? CreatorUserId { get; set; }
    }
}
