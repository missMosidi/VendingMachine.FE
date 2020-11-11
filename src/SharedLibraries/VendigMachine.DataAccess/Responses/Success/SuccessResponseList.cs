using VendigMachine.DataAccess.Responses.Commons;
using VendigMachine.DataAccess.Responses.Unsuccess;

namespace VendigMachine.DataAccess.Responses.Success
{
    public class SuccessResponseList<T> : UnsuccessResponse
    {
        public int StatusCode { get; set; }

        public ResultResponse<T> Results { get; set; }
    }
}
