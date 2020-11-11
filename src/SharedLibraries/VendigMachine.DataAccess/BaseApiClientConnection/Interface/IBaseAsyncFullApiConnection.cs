using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using VendingMachine.Data.Transfer.Objects.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection.Interface
{
    public interface IBaseAsyncFullApiConnection<TAddDto, TUpdateDto, TDto, TDetailedDto, TPrimaryKey> : 
        IBaseAsyncCRUDAPIConnection<TAddDto, TUpdateDto, TDto, TPrimaryKey>
        where TDetailedDto : class
        where TAddDto : class
        where TUpdateDto : class
        where TDto : class
    {
       Task<SuccessResponseList<List<TDetailedDto>>>GetDeletedAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE);

       Task<SuccessResponseList<List<TDetailedDto>>>GetByStatusCodeAsync(StatusCode statusCode, string apiVersion = ApiVersionHistrory.VERSION_ONE);

       Task<SuccessResponseList<List<TDetailedDto>>>GetByStatusIDAsync(long statusId, string apiVersion = ApiVersionHistrory.VERSION_ONE);

       Task<SuccessResponse<string>> RestoreAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE);
    }
}
