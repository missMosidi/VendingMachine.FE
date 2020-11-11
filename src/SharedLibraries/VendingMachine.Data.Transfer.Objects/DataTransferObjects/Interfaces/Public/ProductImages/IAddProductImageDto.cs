using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IAddProductImageDto : IProductImage, IHasStatusIdDto
    {
    }
}
