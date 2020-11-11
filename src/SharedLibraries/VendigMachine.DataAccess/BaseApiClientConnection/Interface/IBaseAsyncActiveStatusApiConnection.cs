using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection.Interface
{
    public interface IBaseAsyncActiveStatusApiConnection<TAddDto, TUpdateDto, TDto, TDetailedDto, TPrimaryKey> : 
        IBaseAsyncCRUDAPIConnection<TAddDto, TUpdateDto, TDto, TPrimaryKey>
        where TAddDto : class
        where TUpdateDto : class
        where TDto : class
        where TDetailedDto : class
    {
        Task<SuccessResponseList<List<TDetailedDto>>> GetDeletedAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponseList<List<TDetailedDto>>> GetByActiveStatusAsync(bool activeStatus, string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<string>> RestoreAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE);

    }
}
