using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Sales
{
    public interface IDetailedSaleDto : ISale, IHasStatusDto, IHasProductDto, IHasCreationTimeDto
    {
    }
}
