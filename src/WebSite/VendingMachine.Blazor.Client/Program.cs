using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using Tewr.Blazor.FileReader;
using VendigMachine.DataAccess.ApiClientConnectionServices.Public.Statuses;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using VendigMachine.DataAccess.ApiClientConnectionServices.Public.StockInventories;
using VendingMachine.Blazor.Client.Utilities;

namespace VendingMachine.Blazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddOptions();
            services.AddBlazoredLocalStorage();
            services.AddSyncfusionBlazor();

            services.AddFileReaderService(options => options.UseWasmSharedBuffer = true);


            services.AddHttpClient("VendingMachineApi", client =>
            {
                //client.BaseAddress = new Uri("https://localhost:5091/api/");
                client.BaseAddress = new Uri("http://13.59.79.172:5090/api/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });


            services.AddScoped<IStatusApiConnectionService, StatusApiConnectionService>();
            services.AddScoped<IStockInventoryApiConnectionService, StockInventoryApiConnectionService>();

            services.AddSingleton<MoneyManagement>();
        }
    }
}
