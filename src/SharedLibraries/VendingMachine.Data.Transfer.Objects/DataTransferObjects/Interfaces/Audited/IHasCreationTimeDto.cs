using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface IHasCreationTimeDto
    {
        DateTime? CreationTime { get; set; }
    }
}
