using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Common;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common
{
    public class FullAuditedEntityDto<TPrimaryKey> : InputBaseEntityDto<TPrimaryKey>, IFullAuditedDto
    {
        public DateTime? CreationTime { get ; set ; }
        public Guid? CreatorUserId { get ; set ; }
        public Guid? LastModifierUserId { get ; set ; }
        public DateTime? ModicationTime { get ; set ; }
        public Guid? DeleterUserId { get ; set ; }
        public DateTime? DeletionTime { get ; set ; }
        public bool IsDeleted { get ; set ; }
    }
}
