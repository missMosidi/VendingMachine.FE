using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VendigMachine.DataAccess.BaseApiClientConnection;
using VendigMachine.DataAccess.Responses.Success;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendigMachine.DataAccess.ApiClientConnectionServices.Public.StockInventories
{
    public class StockInventoryApiConnectionService : BaseAsyncFullApiConnection<AddStockInventoryDto, UpdateStockInventoryDto, StockInventoryDto, DetailedStockInventoryDto, Guid>,
        IStockInventoryApiConnectionService
    {
        public StockInventoryApiConnectionService(IHttpClientFactory httpClient, ILocalStorageService localStorageService) : base(httpClient, localStorageService)
        {
            this._resource = "StockInventories";
        }


        public override Task<SuccessResponseList<List<StockInventoryDto>>> GetAllAsync(string apiVersion = "1.0")
        {
            return base.GetAllAsync(apiVersion);
        }
    }
}
