using Microsoft.AspNetCore.Components;
using System;
using VendingMachine.Blazor.Client.Utilities;

namespace VendingMachine.Blazor.Client.Shared
{
    public partial class MainLayout : LayoutComponentBase, IDisposable
    {
        [Inject] MoneyManagement MoneyManagement { get; set; }

        

        protected override void OnInitialized()
        {
            this.MoneyManagement.ShowModal_OnChange += this.StateHasChanged;
        }

        public void Dispose()
        {
            this.MoneyManagement.ShowModal_OnChange -= this.StateHasChanged;
        }
    }
}
