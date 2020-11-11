using VendigMachine.DataAccess.Responses.Commons;

namespace VendigMachine.DataAccess.Responses.Unsuccess
{
    public class UnsuccessResponse
    {
        public string TargetUrl { get; set; }

        public bool Success { get; set; }

        public Error Error { get; set; }

        public bool UnAuthorizedRequest { get; set; }

        public bool _Igagu { get; set; }
    }
}
