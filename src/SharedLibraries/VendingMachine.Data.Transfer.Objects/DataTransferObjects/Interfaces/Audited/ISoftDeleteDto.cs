namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Interfaces.Audited
{
    public interface ISoftDeleteDto
    {
        bool IsDeleted { get; set; }
    }
}
