namespace VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public
{
    public interface  IStockInventory
    {
        int TotalItems { get; set; }

        bool IsOutOfStock { get; set; }
    }
}
