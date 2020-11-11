using Igagu.Common.Application.Core.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;
using VendingMachine.Data.Transfer.Objects.Enums;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses
{

    public class StatusDto : EntityDto<long>, IStatsuDto
    {
        public StatusCode  StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }
    }
}
