using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories
{
    public class StockInventoryDto : EntityDto<Guid>, IStockInventoryDto
    {
        public int TotalItems { get; set; }
        public bool IsOutOfStock { get; set; }
        public StatusDto Status { get; set; }
        public ProductDto Product { get; set; }
    }
}
