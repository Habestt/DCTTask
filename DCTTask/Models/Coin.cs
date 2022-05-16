using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCTTask.Models
{
    internal class Coin
    {
        public string id { get; set; }
        public string name { get; set; }
        public double current_price { get; set; }
        public double market_cap_rank { get; set; }
        public double total_volume { get; set; }
        public double price_change_24h { get; set; }
        
    }
}
