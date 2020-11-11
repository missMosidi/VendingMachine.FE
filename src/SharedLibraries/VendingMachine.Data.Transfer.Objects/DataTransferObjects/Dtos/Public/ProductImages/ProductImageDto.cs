using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.ProductImages;
using VendingMachine.Data.Transfer.Objects.Utilities;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.ProductImages
{
    public class ProductImageDto : EntityDto<Guid>, IProductImageDto
    {
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }

        public string ImageDescription { get; set; }
        
        public StatusDto Status { get; set; }

    }
}
