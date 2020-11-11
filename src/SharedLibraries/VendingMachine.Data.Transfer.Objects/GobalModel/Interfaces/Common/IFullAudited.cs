using VendingMachine.Data.Transfer.Objects.Interfaces.Audited;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Data.Transfer.Objects.Interfaces.Common
{
    public interface IFullAudited: IHasCreationTime, IHasCreationUser, IHasModificationUser, IHasModificationTime, IHasDeletionUser, IHasDeletionTime, ISoftDelete
    {
    }
}
