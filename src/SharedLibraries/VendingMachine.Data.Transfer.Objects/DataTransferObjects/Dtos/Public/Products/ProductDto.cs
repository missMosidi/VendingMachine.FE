using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Products;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Products
{
    public class ProductDto : EntityDto<Guid>, IProductDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public StatusDto Status { get; set; }
        public ProductImageDto ProductImage { get; set; }
    }
}
