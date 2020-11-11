using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Public.Statuses
{
    public interface IDetialedStatusDto : IStatus, IHasCreationUserDto, IHasCreationTimeDto, IHasModificationUserDto, IHasModificationTimeDto, ISoftDeleteDto, IHasActiveStatusDto
    {
    }
}
