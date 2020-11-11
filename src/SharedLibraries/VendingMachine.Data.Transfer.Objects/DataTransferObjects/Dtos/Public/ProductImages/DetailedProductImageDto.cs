using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.ProductImages;
using VendingMachine.Data.Transfer.Objects.Enums;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.ProductImages
{
    public class DetailedProductImageDto : EntityDto<Guid>, IDetailedProductImageDto
    {
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageDescription { get; set; }
        public StatusDto Status { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public Guid? LastModifierUserId { get; set; }
        public DateTime? ModicationTime { get; set; }
        public Guid? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
