using System.Collections.Generic;

namespace VendigMachine.DataAccess.Responses.Commons
{
    public class Error
    {
        public string Code { get; set; }

        public string Details { get; set; }

        public List<ValidationError> validationErrors { get; set; }
    }
}
