using Syncfusion.Blazor.Grids;
using System;
using VendingMachine.Data.Transfer.Objects.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendingMachine.Blazor.Client.Utilities
{
    public class MoneyManagement
    {

        public event System.Action CurentInputAmount_OnChange;
        public event System.Action ChangeAmount_OnChange;
        public event System.Action SelectProduct_OnChange;
        public event System.Action ShowModal_OnChange;

        private decimal CurrentInputAmount;

        private decimal ChangeAmount;

        private StockInventoryDto SelectedProduct;

        private bool ShowModal;

        


        public void SetCurrentInputAmount(decimal data)
        {
            this.CurrentInputAmount += data;
            this.CurentInputAmount_OnChange?.Invoke();
        }

        public decimal GetCurrentinputAmount()
        {
            return this.CurrentInputAmount;
        }


        public void SetChangAmount(decimal data)
        {
            this.ChangeAmount = data;
            this.ChangeAmount_OnChange?.Invoke();
        }

        public decimal GetChangeAmount()
        {
            return this.ChangeAmount;
        }

        public void SetSelectProduct(StockInventoryDto data)
        {
            this.SelectedProduct = data;
            this.SelectProduct_OnChange?.Invoke();
        }

        public StockInventoryDto GetSelectedProduct()
        {
            return this.SelectedProduct;
        }

        public void SetShowModal(bool data)
        {
            this.ShowModal = data;
            this.ShowModal_OnChange?.Invoke();
        }

        public bool GetShowModal()
        {
            return this.ShowModal;
        }
    }
}
