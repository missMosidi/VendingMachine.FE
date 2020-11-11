using VendingMachine.Data.Transfer.Objects.Enums;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common
{
    public interface IHasStatusCode
    {
        StatusCode StatusCode { get; set; }
    }
}
