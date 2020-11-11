using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Sales;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Sales
{
    public class SaleDto : ISaleDto
    {
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Change { get; set; }
        public StatusDto Status { get; set; }
        public ProductDto Product { get; set; }
    }
}
