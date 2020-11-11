using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common
{
    public interface IHasProductImageIdDto
    {
        Guid? ProductImageId { get; set; }
    }
}
