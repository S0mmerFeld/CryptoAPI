using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Web.BlazorDTOs.CryptingApp_DTO
{
    public class RootDTO
    {
        public List<AssetDTO> assets { get; set; }
        public string next { get; set; }
    }
}
