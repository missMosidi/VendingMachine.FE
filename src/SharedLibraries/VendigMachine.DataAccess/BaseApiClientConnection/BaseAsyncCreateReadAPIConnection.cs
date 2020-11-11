using Blazored.LocalStorage;
using VendigMachine.DataAccess.BaseApiClientConnection.Interface;
using VendigMachine.DataAccess.Responses.Success;
using VendigMachine.DataAccess.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine.DataAccess.BaseApiClientConnection
{
    public abstract class BaseAsyncCreateReadAPIConnection<TAddDto, TDto, TPrimaryKey> : 
        BaseApiConnection, IBaseAsyncCreateReadAPIConnection<TAddDto, TDto, TPrimaryKey>
        where TAddDto : class
        where TDto : class
    {
        protected BaseAsyncCreateReadAPIConnection(IHttpClientFactory httpClient, ILocalStorageService localStorageService) : base(httpClient, localStorageService)
        {

        }

        public virtual async Task<SuccessResponse<string>> AddAsync(TAddDto value, string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            string path = $"{this._resource}{EndPointRoutesParams.CREATE}?api-version={apiVersion}";

            var client = httpClient.CreateClient("VendingMachineApi");

            HttpResponseMessage response;

            var Body = new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json");

            if (this.localStorageService != null && !String.IsNullOrEmpty(await this.localStorageService.GetItemAsync<string>("token")))
            {
                
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, path);
                requestMessage.Content = Body;


                var token = await this.localStorageService.GetItemAsync<string>("token");

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                response = await client.SendAsync(requestMessage);
            }
            else
            {
                response = await client.PostAsync(path, Body);
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

        public virtual async Task<SuccessResponseList<List<TDto>>> GetAllAsync(string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            var client = httpClient.CreateClient("VendingMachineApi");

            string path = $"{this._resource}{EndPointRoutesParams.GETALL}?api-version={apiVersion}";

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
                return JsonConvert.DeserializeObject<SuccessResponseList<List<TDto>>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDto>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponseList<List<TDto>>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.InternalServerError;

                return data;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public virtual async Task<SuccessResponse<TDto>> GetByIDAsync(TPrimaryKey id, string apiVersion = ApiVersionHistrory.VERSION_ONE)
        {
            var client = httpClient.CreateClient("VendingMachineApi");

            string path = $"{this._resource}{EndPointRoutesParams.GET_BY_ID}{id.ToString()}?api-version={apiVersion}";

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
                return JsonConvert.DeserializeObject<SuccessResponse<TDto>>(responseStream);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {

                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponse<TDto>>(responseStream);

                data.StatusCode = (int)HttpStatusCode.NoContent;

                return data;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SuccessResponse<TDto>>(responseStream);

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
