using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IDetailedProductImageDto : IProductImage, IHasStatusDto, IHasCreationUserDto, IHasCreationTimeDto, IHasModificationUserDto, IHasModificationTimeDto, IHasDeletionUserDto, IHasDeletionTimeDto, ISoftDeleteDto
    {
    }
}
