using Microsoft.AspNetCore.Components;
using System;

namespace VendingMachine.Blazor.Client.Shared
{
    public partial class ImageCardVeiwerComponent
    {
        [Parameter]
        public string ImageURL { get; set; }

        [Parameter]
        public Byte[] ImageData { get; set; }

        [Parameter]
        public string ImageBase64Data { get; set; }

        [Parameter]
        public string ImageALT { get; set; }
    }
}
