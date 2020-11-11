using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Products;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common
{
    public interface IHasProductDto
    {
        ProductDto Product { get; set; }
    }
}
