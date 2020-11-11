using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common
{
    public interface IHasProductIdDto
    {
        Guid? ProductId { get; set; }
    }
}
