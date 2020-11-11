using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common
{
    public interface IHasStatusDto
    {
        StatusDto Status { get; set; }
    }
}
