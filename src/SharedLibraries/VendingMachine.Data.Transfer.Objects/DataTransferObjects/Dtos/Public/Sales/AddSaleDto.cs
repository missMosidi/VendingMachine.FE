using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Sales;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Sales
{
    public class AddSaleDto : IAddSaleDto
    {
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Change { get; set; }
        public long? StatusId { get; set; }
        public Guid? ProductId { get; set; }
    }
}
