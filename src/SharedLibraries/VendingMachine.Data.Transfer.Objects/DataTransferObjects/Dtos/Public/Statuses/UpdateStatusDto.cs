using VendingMachine.Data.Transfer.Objects.Enums;
using System;
using Igagu.Common.Application.Core.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses
{

    public class UpdateStatusDto : InputBaseEntityDto<long>, IUpdateStatusDto
    {
        public StatusCode StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }

        public bool ActiveStatus { get; set; }
    }
}
