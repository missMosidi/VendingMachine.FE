using System.Collections.Generic;

namespace VendigMachine.DataAccess.Responses.Commons
{
    public class ValidationError
    {
        public string Message { get; set; }

        public List<string> Members { get; set; }
    }
}
