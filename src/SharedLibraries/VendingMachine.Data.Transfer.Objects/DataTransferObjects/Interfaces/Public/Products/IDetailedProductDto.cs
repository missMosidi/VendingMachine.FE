using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Products
{
    public interface IDetailedProductDto : IProduct, IHasProductImageDto, IHasStatusDto, IHasCreationUserDto, IHasCreationTimeDto, IHasModificationUserDto, IHasModificationTimeDto, IHasDeletionUserDto, IHasDeletionTimeDto, ISoftDeleteDto
    {
    }
}
