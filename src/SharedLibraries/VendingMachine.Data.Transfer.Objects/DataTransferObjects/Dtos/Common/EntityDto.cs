namespace VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Common
{
    public class EntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
