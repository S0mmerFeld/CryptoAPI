using Crypto.Web.BlazorDTOs;
using Crypto.Web.BlazorDTOs.CryptingApp_DTO;
using Crypto.Web.Clients;
using Crypto.Web.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Crypto.Web.Clients
{
    public class CryptoClient : GenericClient<RootDTO>, ICryptoClient
    {
        public CryptoClient(HttpClient client) : base(client, "CryptingApp") { }
      
    }
}
