using DCTTask.API;
using DCTTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCTTask.Services
{
    internal class MarketService
    {
        public async Task<IEnumerable<Market>> GetCoinMarkets(string id)
        {
            string url = $"assets/{id}/markets?limit=500";
            var da = new DataAccess<Data<Market>>();
            var markets = await da.GetData(url);

            return markets.data;
        }
    }
}
