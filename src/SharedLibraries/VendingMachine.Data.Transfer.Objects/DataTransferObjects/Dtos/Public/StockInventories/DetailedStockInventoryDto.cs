using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories
{
    public class DetailedStockInventoryDto : EntityDto<Guid>, IDetailedStockInventoryDto
    {
        public int TotalItems { get; set; }
        public bool IsOutOfStock { get; set; }
        public StatusDto Status { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public Guid? LastModifierUserId { get; set; }
        public DateTime? ModicationTime { get; set; }
        public Guid? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public ProductDto Product { get; set; }
    }
}
