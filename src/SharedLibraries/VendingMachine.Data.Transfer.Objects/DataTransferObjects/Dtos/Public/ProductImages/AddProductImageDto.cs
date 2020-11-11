using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.ProductImages;
using VendingMachine.Data.Transfer.Objects.Utilities;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.ProductImages
{
    public class AddProductImageDto : IAddProductImageDto
    {
        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_NAME_LENGHT)]
        public string ImageName { get; set; }

        [Required]
        public byte[] ImageData { get; set; }
        
        [StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_DESCRIPTION_LENGHT)]
        public string ImageDescription { get; set; }

        [Required]
        public long? StatusId { get; set; }
    }
}
