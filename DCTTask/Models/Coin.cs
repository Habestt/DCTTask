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
        public double priceUsd { get; set; }
        public double rank { get; }
        public double volumeUsd24Hr { get; set; }
        public double changePercent24Hr { get; set; }        
    }
}
