using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAPI.Models.Entities
{
    public class Asset
    {
        public Quote quote { get; set; }
        public string asset_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string website { get; set; }
        public string ethereum_contract_address { get; set; }
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double change_1h { get; set; }
        public double change_24h { get; set; }
        public double change_7d { get; set; }
        public double total_supply { get; set; }
        public double circulating_supply { get; set; }
        public long max_supply { get; set; }
        public double market_cap { get; set; }
        public double fully_diluted_market_cap { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
