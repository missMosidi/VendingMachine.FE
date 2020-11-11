using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace Igagu.Common.Application.Core.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses
{
    public interface IAddStatusDto: IStatus, IHasActiveStatusDto
    {

    }
}
