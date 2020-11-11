using VendingMachine.Data.Transfer.Objects.Enums;

namespace VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public
{
    public interface IStatus
    {
        public StatusCode StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }
    }
}
