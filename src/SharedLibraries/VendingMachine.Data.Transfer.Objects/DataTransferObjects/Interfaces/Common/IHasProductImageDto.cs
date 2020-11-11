using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.ProductImages;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common
{
    public interface IHasProductImageDto
    {
        ProductImageDto ProductImage { get; set; }
    }
}
