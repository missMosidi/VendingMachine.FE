using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common
{
    public class InputBaseEntityDto<TPrimaryKey>
    {
        [Required]
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public TPrimaryKey Id { get; set; }
    }
}
