using Crypto.Web.BlazorDTOs;
using Crypto.Web.BlazorDTOs.CryptingApp_DTO;
using Crypto.Web.Clients.Interfaces;
using Crypto.Web.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto.Web.Services
{
    public class CryptoService : ICryptoService
    {
        private readonly ICryptoClient _iCryptoClient;
        public CryptoService(ICryptoClient iCryptoClient)
        {
            _iCryptoClient = iCryptoClient;
        }

        public async Task<IEnumerable<AssetDTO>> GetAll()
        {
            var c = await _iCryptoClient.GetAll();
            return c.assets;
        }

        public async Task<IEnumerable<AssetDTO>> GetCrypto(string cr_name)
        {
            var c = await _iCryptoClient.GetAll();

            var cryptos = c.assets.Where(c => c.name.ToUpper().Contains(cr_name.ToUpper()));

            return cryptos;
        }





    }
}
