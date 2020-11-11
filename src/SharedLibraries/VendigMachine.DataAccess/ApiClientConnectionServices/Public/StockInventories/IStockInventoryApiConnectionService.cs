using System;
using VendigMachine.DataAccess.BaseApiClientConnection.Interface;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendigMachine.DataAccess.ApiClientConnectionServices.Public.StockInventories
{
    public interface IStockInventoryApiConnectionService : IBaseAsyncFullApiConnection<AddStockInventoryDto, UpdateStockInventoryDto, StockInventoryDto, DetailedStockInventoryDto, Guid>
    {

    }
}
