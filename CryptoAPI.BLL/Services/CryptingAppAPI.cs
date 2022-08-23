using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using CryptoAPI.Models.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CryptoAPI.BLL.Services

{
	public class CryptingAppAPI
	{
		private readonly HttpClient _httpClient;
		private readonly string _url;
		private readonly string _Id;

		public CryptingAppAPI(HttpClient httpClient, IConfiguration config)
		{
			_httpClient = httpClient;
			_url = config.GetSection("cryptingupApiOptions")["Url"];
			_Id = config.GetSection("cryptingupApiOptions")["Id"];
		}

		public async Task<Root> GetAll()
		{
			//string url = $"{_url}/assets?start={_Id}";
			string url = $"https://cryptingup.com/api/assets?start=8423129941";
			var response = await _httpClient.GetAsync(url);
			string strbody = await response.Content.ReadAsStringAsync();

			Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(strbody);
			return myDeserializedClass;
		}

		public async Task<Root> GetBySize(int size)
		{
			string url = $"{_url}/assets?size={size}";
			var response = await _httpClient.GetAsync(url);
			string strbody = await response.Content.ReadAsStringAsync();

			Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(strbody);
			return myDeserializedClass;
		}

	}
}
