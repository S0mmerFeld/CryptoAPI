using Crypto.Web.BlazorDTOs;
using Crypto.Web.BlazorDTOs.CryptingApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto.Web.Services.Interfaces
{
    public interface ICryptoService
    {
        Task<IEnumerable<AssetDTO>> GetAll();
        Task<IEnumerable<AssetDTO>> GetCrypto(string str);

    }
}
