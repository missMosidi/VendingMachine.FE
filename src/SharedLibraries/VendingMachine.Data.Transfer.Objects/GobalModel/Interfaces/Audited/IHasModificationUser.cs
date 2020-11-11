using System;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface IHasModificationUser
    {
        Guid? LastModifierUserId { get; set; }
    }
}
