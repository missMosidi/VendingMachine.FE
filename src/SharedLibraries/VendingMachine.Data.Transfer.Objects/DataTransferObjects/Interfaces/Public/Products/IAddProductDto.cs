﻿using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Common;
using VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public;

namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interface.Public.Products
{
    public interface IAddProductDto : IProduct, IHasStatusIdDto, IHasProductImageIdDto
    {
    }
}
