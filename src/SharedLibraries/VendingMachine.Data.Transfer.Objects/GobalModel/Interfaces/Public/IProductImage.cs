namespace VendingMachine.Data.Transfer.Objects.GobalModel.Interfaces.Public
{
    public interface IProductImage
    {
        string ImageName { get; set; }

        byte[] ImageData { get; set;}

        string ImageDescription { get; set; }
    }
}
