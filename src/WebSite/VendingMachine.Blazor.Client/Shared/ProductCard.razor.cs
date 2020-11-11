using Microsoft.AspNetCore.Components;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendingMachine.Blazor.Client.Shared
{
    public partial class ProductCard : ComponentBase
    {
        [Parameter] public  StockInventoryDto Data { get; set; }
        [Parameter] public EventCallback<StockInventoryDto> OnClick { get; set; }

        private async void OnBuy_Click()
        {
            await this.OnClick.InvokeAsync(Data);
        }

        
    }
}
