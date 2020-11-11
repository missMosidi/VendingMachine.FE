using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Sales
{
    public interface IAddSaleDto : ISale, IHasStatusIdDto, IHasProductIdDto
    {
    }
}
