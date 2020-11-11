using Igagu.Common.Application.Core.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Data.Transfer.Objects.Enums;
using System;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.Statuses
{

    public class AddStatusDto : IAddStatusDto
    {
        public StatusCode StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }

        public bool ActiveStatus { get; set; }
    }
}
