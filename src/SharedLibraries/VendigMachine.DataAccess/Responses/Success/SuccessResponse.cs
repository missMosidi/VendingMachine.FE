using VendigMachine.DataAccess.Responses.Unsuccess;

namespace VendigMachine.DataAccess.Responses.Success
{
    public class SuccessResponse<T> : UnsuccessResponse
    {
        public int StatusCode { get; set; }

        public T Results { get; set; }
    }
}
