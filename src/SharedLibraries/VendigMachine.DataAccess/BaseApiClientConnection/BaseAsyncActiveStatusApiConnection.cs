using Blazored.LocalStorage;
using VendigMachine.DataAccess.BaseApiClientConnection.Interface;
using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection
{
    public abstract class BaseAsyncActiveStatusApiConnection<TAddDto, TUpdateDto, TDto, TDetailedDto,TPrimaryKey> :
        BaseAsyncCRUDAPIConnection<TAddDto, TUpdateDto, TDto, TPrimaryKey>,
        IBaseAsyncActiveStatusApiConnection<TAddDto, TUpdateDto, TDto, TDetailedDto, TPrimaryKey>
        where TAddDto : class
        where TUpdateDto : class
        where TDto : class
        where TDetailedDto : class
    {
        protected BaseAsyncActiveStatusApiConnection(IHttpClientFactory httpClient, ILocalStorageService localStorageService) : base(httpClient, localStorageService)
        {

        }

        public async Task<SuccessResponseList<List<TDetailedDto>>> GetByActiveStatusAsync(bool activeStatus, string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            string path = $"{this._resource}/By/Active/Status/{activeStatus}?api-version={apiVersion}";
            var client = httpClient.CreateClient("VendingMachineApi");

            HttpResponseMessage response;

            if(this.localStorageService != null && !String.IsNullOrEmpty( await this.localStorageService.GetItemAsync<string>("token")))
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, path);

                var token = await this.localStorageService.GetItemAsync<string>("token");

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                response = await client.SendAsync(requestMessage);
            }
            else
            {
                response = await client.GetAsync(path);
            }

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SuccessResponseList<List<TDetailedDto>>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDetailedDto>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDetailedDto>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.InternalServerError;

                return data;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<SuccessResponseList<List<TDetailedDto>>> GetDeletedAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            string path = $"{this._resource}/Deleted?api-version={apiVersion}";

            var client = httpClient.CreateClient("VendingMachineApi");

            HttpResponseMessage response;

            if (this.localStorageService != null && !String.IsNullOrEmpty(await this.localStorageService.GetItemAsync<string>("token")))
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, path);

                var token = await this.localStorageService.GetItemAsync<string>("token");

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                response = await client.SendAsync(requestMessage);
            }
            else
            {
                response = await client.GetAsync(path);
            }


            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SuccessResponseList<List<TDetailedDto>>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDetailedDto>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDetailedDto>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.InternalServerError;

                return data;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<SuccessResponse<string>> RestoreAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            string path = $"{this._resource}/Restore/{id.ToString()}?api-version={apiVersion}";

            var client = httpClient.CreateClient("VendingMachineApi");

            HttpResponseMessage response;

            if (this.localStorageService != null && !String.IsNullOrEmpty(await this.localStorageService.GetItemAsync<string>("token")))
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Put, path);
                requestMessage.Content = null;


                var token = await this.localStorageService.GetItemAsync<string>("token");

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                response = await client.SendAsync(requestMessage);
            }
            else
            {
                response = await client.PutAsync(path, null);
            }

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SuccessResponse<string>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponse<string>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponse<string>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.InternalServerError;

                return data;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
