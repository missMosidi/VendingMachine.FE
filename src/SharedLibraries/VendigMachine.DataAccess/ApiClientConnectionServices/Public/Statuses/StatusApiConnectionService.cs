using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VendigMachine.DataAccess.BaseApiClientConnection;
using VendigMachine.DataAccess.Responses.Success;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses;

namespace VendigMachine.DataAccess.ApiClientConnectionServices.Public.Statuses
{
    public class StatusApiConnectionService : BaseAsyncActiveStatusApiConnection<AddStatusDto, UpdateStatusDto, StatusDto, DetailedStatusDto, long>,
        IStatusApiConnectionService
    {
        public StatusApiConnectionService(IHttpClientFactory httpClient, ILocalStorageService localStorageService) : base(httpClient, localStorageService)
        {
            this._resource = "Statuses";
        }

        public override Task<SuccessResponseList<List<StatusDto>>> GetAllAsync(string apiVersion = "1.0")
        {
            return base.GetAllAsync(apiVersion);
        }
    }
}
