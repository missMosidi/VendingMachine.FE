using System;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface IHasDeletionUser
    {
        
        Guid? DeleterUserId { get; set; }
    }
}
