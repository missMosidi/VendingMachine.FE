using Microsoft.AspNetCore.Components;
using VendingMachine.Blazor.Client.Utilities;

namespace VendingMachine.Blazor.Client.Shared
{
    public partial class ModelCard : ComponentBase
    {
        [Inject] MoneyManagement MoneyManagement { get; set; }

        private int NumberOFOneRandCions;
        private int NumberOFTwoRandCions;
        private int NumberOFFiveRandCoins;

        protected override void OnInitialized()
        {
            decimal change = this.MoneyManagement.GetChangeAmount();

            this.NumberOFFiveRandCoins = (int)(change / 5.00m);

            if(this.NumberOFFiveRandCoins >= 1)
            {
                change = change - (5.00m * this.NumberOFFiveRandCoins);
            }

            this.NumberOFTwoRandCions = (int)(change / 2.00m);

            if(this.NumberOFTwoRandCions >= 1)
            {
                change = change - (2.00m * this.NumberOFTwoRandCions);
            }

            this.NumberOFOneRandCions = (int)(change / 1.00m);

            if(this.NumberOFOneRandCions >= 1)
            {
                change = (int)(change / 1.00m);
            }

            this.StateHasChanged();
        }


        private void TakeChange_OnClick()
        {
            this.MoneyManagement.SetCurrentInputAmount(this.MoneyManagement.GetCurrentinputAmount() * -1);
            this.MoneyManagement.SetChangAmount(0m);
            this.MoneyManagement.SetShowModal(false);
        }
    }
}
