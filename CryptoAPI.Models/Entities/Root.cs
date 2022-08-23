using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAPI.Models.Entities
{
    public class Root
    {
        public List<Asset> assets { get; set; }
        public string next { get; set; }

    }
}
