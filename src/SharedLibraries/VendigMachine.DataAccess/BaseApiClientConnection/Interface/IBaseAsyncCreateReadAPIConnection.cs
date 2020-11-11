using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection.Interface
{
    public interface IBaseAsyncCreateReadAPIConnection<TAddDto, TDto, TPrimaryKey>
    {
        Task<SuccessResponseList<List<TDto>>> GetAllAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<TDto>> GetByIDAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<string>> AddAsync(TAddDto value, string apiVersion = ApiVersionHistrory.VERSION_ONE);
    }
}
