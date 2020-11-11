namespace VendingMachine.Data.Transfer.Objects.Interfaces.Common
{
    public interface IHasActiveStatus
    {
        bool? ActiveStatus { get; set; }
    }
}
