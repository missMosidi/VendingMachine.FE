using Blazored.LocalStorage;
using VendigMachine.DataAccess.BaseApiClientConnection.Interface;
using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using VendingMachine.Data.Transfer.Objects.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection
{
    public abstract class BaseAsyncFullApiConnection<TAddDto, TUpdateDto, TDto, TDeatailed, TPrimaryKey> :
        BaseAsyncCRUDAPIConnection<TAddDto, TUpdateDto, TDto, TPrimaryKey>, 
        IBaseAsyncFullApiConnection<TAddDto, TUpdateDto, TDto, TDeatailed, TPrimaryKey>
        where TAddDto : class
        where TUpdateDto : class
        where TDto : class
        where TDeatailed : class
    {
        protected BaseAsyncFullApiConnection(IHttpClientFactory httpClient, ILocalStorageService localStorageService) : base(httpClient, localStorageService)
        {

        }

        public async Task<SuccessResponseList<List<TDeatailed>>> GetByStatusCodeAsync(StatusCode statusCode, string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            var client = httpClient.CreateClient("VendingMachineApi");

            string path = $"{this._resource}{EndPointRoutesParams.GET_BY_STATUS_CODE}{statusCode}?api-version={apiVersion}";

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
                return JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.InternalServerError;

                return data;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<SuccessResponseList<List<TDeatailed>>> GetByStatusIDAsync(long statusId, string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            var client = httpClient.CreateClient("VendingMachineApi");

            string path = $"{this._resource}{EndPointRoutesParams.GET_BY_STATUS_ID}{statusId}?api-version={apiVersion}";

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
                return JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.InternalServerError;

                return data;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<SuccessResponseList<List<TDeatailed>>> GetDeletedAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            var client = httpClient.CreateClient("VendingMachineApi");

            string path = $"{this._resource}{EndPointRoutesParams.GET_DELETED}?api-version={apiVersion}";

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
                return JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDeatailed>>>(responseStream);

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
            var client = httpClient.CreateClient("VendingMachineApi");

            string path = $"{this._resource}{EndPointRoutesParams.RESTORE}{id}?api-version={apiVersion}";

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
