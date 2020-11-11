namespace VendingMachine.Data.Transfer.Objects.Interfaces.Audited
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
