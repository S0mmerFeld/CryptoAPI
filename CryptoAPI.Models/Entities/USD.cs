using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAPI.Models.Entities
{
    public class USD
    {
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double market_cap { get; set; }
        public double fully_diluted_market_cap { get; set; }
    } 
}
