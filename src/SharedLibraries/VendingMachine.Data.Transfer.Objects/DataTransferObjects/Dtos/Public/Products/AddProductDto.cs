using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Products;
using VendingMachine.Data.Transfer.Objects.Utilities;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Products
{
    public class AddProductDto : IAddProductDto
    {
        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_NAME_LENGHT)]
        public string ProductName { get; set; }

        [StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_DESCRIPTION_LENGHT)]
        public string ProductDescription { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public long? StatusId { get; set; }
        
        [Required]
        public Guid? ProductImageId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? CreatorUserId { get; set; }
    }
}
