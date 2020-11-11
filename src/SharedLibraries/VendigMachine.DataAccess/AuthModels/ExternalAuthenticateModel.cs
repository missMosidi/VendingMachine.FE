using VendigMachine.DataAccess.Utilities;
using System.ComponentModel.DataAnnotations;

namespace VendigMachine.DataAccess.AuthModels
{
    public class ExternalAuthenticateModel
    {
        [Required]
        public string AuthProvider { get; set; }

        [Required]
        public string ProviderKey { get; set; }

        [Required]
        public string ProviderAccessCode { get; set; }
    }
}
