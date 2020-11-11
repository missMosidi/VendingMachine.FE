using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.Enums;
using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses
{
    public class DetailedStatusDto : EntityDto<long>, IDetialedStatusDto
    {
        public StatusCode StatusCode { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public Guid? LastModifierUserId { get; set; }
        public DateTime? ModicationTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
