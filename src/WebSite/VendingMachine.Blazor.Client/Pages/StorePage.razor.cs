using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using VendigMachine.DataAccess.ApiClientConnectionServices.Public.StockInventories;
using VendingMachine.Blazor.Client.Utilities;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendingMachine.Blazor.Client.Pages
{
    public partial class StorePage : ComponentBase , IDisposable
    {
        [Inject] IStockInventoryApiConnectionService stockInventoryApi { get; set; }
        [Inject] MoneyManagement MoneyManagement { get; set; }

        private List<StockInventoryDto> StockInventoryDtos;

        private bool ShowError;
        private Timer errorTimer;

        protected override async Task OnInitializedAsync()
        {
            this.MoneyManagement.CurentInputAmount_OnChange += this.StateHasChanged;
            this.MoneyManagement.ChangeAmount_OnChange += this.StateHasChanged;
            this.errorTimer = new Timer();
            this.errorTimer.Interval = 2000;
            this.errorTimer.Elapsed += this.ErrorTimeRestor;

            await this.Refresh_OnClick();

        }

        int count = 0;

        private async void ErrorTimeRestor(object sender, ElapsedEventArgs e)
        {
            if(count  >= 1)
            {
                this.ShowError = false;
                this.errorTimer.Stop();
                count = 0;
            }

            count++;

            await this.InvokeAsync(this.StateHasChanged);
            
        }

        private async Task Refresh_OnClick()
        {
            try
            {
                this.StockInventoryDtos = null;

                this.StateHasChanged();

                var response = await this.stockInventoryApi.GetAllAsync();

                this.StockInventoryDtos = response.Results.Item;

                this.StateHasChanged();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            await Task.CompletedTask;
        }

        private async Task Buy_OnClick(StockInventoryDto data)
        {

            try
            {
                if (data?.Product?.ProductPrice <= this.MoneyManagement.GetCurrentinputAmount())
                {
                    var updateData = new UpdateStockInventoryDto
                    {
                        Id = data.Id,
                        IsOutOfStock = (data.TotalItems - 1) <= 0 ? true : false,
                        ProductId = data.Product.Id,
                        StatusId = data.Status.Id,
                        TotalItems = data.TotalItems > 0 ? data.TotalItems - 1 : 0
                    };

                    int index = this.StockInventoryDtos.IndexOf(data);


                    data.TotalItems = data.TotalItems > 0 ? data.TotalItems - 1 : 0;
                    data.IsOutOfStock = (data.TotalItems - 1) <= 0 ? true : false;

                    var change = this.MoneyManagement.GetCurrentinputAmount() - data.Product.ProductPrice;

                    this.MoneyManagement.SetChangAmount(change);
                    this.MoneyManagement.SetSelectProduct(data);
                    this.MoneyManagement.SetCurrentInputAmount(0.00m);
                    this.MoneyManagement.SetShowModal(true);


                    var response = await this.stockInventoryApi.UpdateAsync(data.Id, updateData);

                    if (response.Success == true)
                    {
                        this.StockInventoryDtos[index] = data;
                        this.StateHasChanged();
                    }
                }
                else
                {
                    this.ShowError = true;
                    this.errorTimer.Start();
                    this.StateHasChanged();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            await Task.CompletedTask;
        }

        private void AddCion_OnClick(decimal coin)
        {
            this.MoneyManagement.SetCurrentInputAmount(coin);
        }

        public void Dispose()
        {
            this.MoneyManagement.CurentInputAmount_OnChange -= this.StateHasChanged;
            this.MoneyManagement.ChangeAmount_OnChange -= this.StateHasChanged;
        }
    }
}
