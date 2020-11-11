using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection.Interface
{
    public interface IBaseAsyncCRUDAPIConnection<TAddDto, TUpdateDto, TDto, TPrimaryKey>
        where TAddDto : class
        where TUpdateDto : class
        where TDto : class
    {
        Task<SuccessResponseList<List<TDto>>> GetAllAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<TDto>> GetByIDAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<string>> AddAsync(TAddDto value, string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<string>> UpdateAsync(TPrimaryKey id, TUpdateDto value, string apiVersion = ApiVersionHistrory.VERSION_ONE);

        Task<SuccessResponse<string>> DeleteAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE);
    }
}
