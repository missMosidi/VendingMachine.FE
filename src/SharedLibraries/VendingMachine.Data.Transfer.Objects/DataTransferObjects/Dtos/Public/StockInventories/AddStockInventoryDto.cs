﻿using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories
{
    public class AddStockInventoryDto : IAddStockInventoryDto
    {
        [Required]
        public int TotalItems { get; set; }

        public bool IsOutOfStock { get; set; }
        
        [Required]
        public long? StatusId { get; set; }
        
        [Required]
        public Guid? ProductId { get; set; }
    }
}
