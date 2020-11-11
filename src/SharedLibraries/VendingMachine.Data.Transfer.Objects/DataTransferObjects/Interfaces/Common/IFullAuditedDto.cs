using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Common
{
    public interface IFullAuditedDto : IHasCreationTimeDto, IHasCreationUserDto, IHasModificationUserDto, IHasModificationTimeDto, IHasDeletionUserDto, IHasDeletionTimeDto, ISoftDeleteDto
    {

    }
}
