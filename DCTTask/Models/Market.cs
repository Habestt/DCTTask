using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCTTask.Models
{
    internal class Market
    {
        public int? rank { get; set; }
        public string? exchangeId { get; set; }
        public string? baseSymbol { get; set; }
        public string? quoteSymbol { get; set; }
        public double? priceUsd { get; set; }
    }
}
