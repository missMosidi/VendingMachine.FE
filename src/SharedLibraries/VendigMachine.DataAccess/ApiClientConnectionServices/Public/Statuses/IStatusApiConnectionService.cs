using VendigMachine.DataAccess.BaseApiClientConnection.Interface;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;

namespace VendigMachine.DataAccess.ApiClientConnectionServices.Public.Statuses
{
    public interface IStatusApiConnectionService : IBaseAsyncActiveStatusApiConnection<AddStatusDto, UpdateStatusDto, StatusDto, DetailedStatusDto, long>
    {
    }
}
