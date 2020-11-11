using System.Collections.Generic;

namespace VendigMachine.DataAccess.Responses.Commons
{
    public  class InternalServerResponse
    {
        public  int StatusCode { get; set; }

        public  string Message { get; set; }

        public  string SubMessage { get; set; }

        public  List<string> Instructions { get; set; }
    }
}
