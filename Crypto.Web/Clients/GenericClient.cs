using Crypto.Web.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Crypto.Web.Clients
{
    public abstract class GenericClient<T> : IClient<T> where T: class
    {

        protected readonly HttpClient httpClient = new HttpClient();
        //Get string to adress controller
        protected readonly string StringToController;       

        public GenericClient(HttpClient client, string requestURL)
        {
            StringToController = requestURL;
            httpClient = client;            
        }

        public async Task<IEnumerable<T>> GetAllItems()
        {
            return await httpClient.GetFromJsonAsync<List<T>>(StringToController);
        }

        public async Task<T> GetAll()
        {
            return await httpClient.GetFromJsonAsync<T>(StringToController);
        }

        public async Task<IEnumerable<T>> GetCompositionByProduct(string name)
        {
            return await httpClient.GetFromJsonAsync<List<T>>($"{StringToController}/{name}");
        }

        public async Task<bool> Add_quantity(string product, int quantity, T entity)
        {
            var response = await httpClient.PutAsJsonAsync($"{StringToController}/{product}, {quantity}", entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<T> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<T>($"{StringToController}/{id}");
        }

        public async Task<bool> Create(T entity)
        {
            var response = await httpClient.PostAsJsonAsync(StringToController, entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> Update(int entityId, T entity)
        {
            var response = await httpClient.PutAsJsonAsync($"{StringToController}/{entityId}", entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> Delete(int id)
        {
            var response = await httpClient.DeleteAsync($"{StringToController}/{id}");
            return response.IsSuccessStatusCode;
        }

       
    }
}
