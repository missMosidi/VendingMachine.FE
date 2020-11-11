using Blazored.LocalStorage;
using System.Net.Http;

namespace VendigMachine.DataAccess.BaseApiClientConnection
{
    public abstract class BaseApiConnection
    {
        protected readonly IHttpClientFactory httpClient;
        protected readonly ILocalStorageService localStorageService;
        protected string _resource;

        protected BaseApiConnection(IHttpClientFactory httpClient, ILocalStorageService localStorageService)
        {
            System.Console.WriteLine("BaseApiConnection Started");

            this.httpClient = httpClient;
            this.localStorageService = localStorageService;
        }
    }
}
